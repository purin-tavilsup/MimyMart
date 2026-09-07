using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace MimyMart.Infrastructure.Services.RawDeviceInput
{
    [type: SupportedOSPlatform("windows")]
	public sealed class RawKeyboard
	{
		public delegate void DeviceEventHandler(object sender, RawInputEventArg e);
		public event DeviceEventHandler? KeyPressed;
		// Per instance, not static: this holds the packet currently being decoded, so sharing it
		// across instances would let one keyboard's key overwrite another's mid-barcode.
		private InputData _rawBuffer;
		private readonly object _padLock = new();
		private readonly Dictionary<IntPtr,KeyPressEvent> _deviceList = new();
		private readonly string _barcodeScannerDeviceName;

		public int NumberOfKeyboards { get; private set; }
		
		public RawKeyboard(IntPtr handle, bool captureOnlyInForeground, string barcodeScannerDeviceName)
		{
			var rawInputDevice = new RawInputDevice[1];

			rawInputDevice[0].UsagePage = HidUsagePage.GENERIC;       
			rawInputDevice[0].Usage = HidUsage.Keyboard;              
            rawInputDevice[0].Flags = (captureOnlyInForeground ? RawInputDeviceFlags.NONE : RawInputDeviceFlags.INPUTSINK) | RawInputDeviceFlags.DEVNOTIFY;
			rawInputDevice[0].Target = handle;

			_barcodeScannerDeviceName = barcodeScannerDeviceName;

			if(!Win32.RegisterRawInputDevices(rawInputDevice, (uint)rawInputDevice.Length, (uint)Marshal.SizeOf(rawInputDevice[0])))
			{
				throw new ApplicationException("Failed to register raw input device(s).");
			}
		}

		public void EnumerateDevices()
		{
			lock (_padLock)
			{
				_deviceList.Clear();

				var keyboardNumber = 0;
				var numberOfDevices = 0;
				uint deviceCount = 0;
				var dwSize = (Marshal.SizeOf(typeof(Rawinputdevicelist)));

				if (Win32.GetRawInputDeviceList(IntPtr.Zero, ref deviceCount, (uint)dwSize) == 0)
				{
					var pRawInputDeviceList = Marshal.AllocHGlobal((int)(dwSize * deviceCount));

					// try/finally so an unmanaged buffer is not leaked when a marshalling call
					// throws partway through enumeration.
					try
					{
						_ = Win32.GetRawInputDeviceList(pRawInputDeviceList, ref deviceCount, (uint)dwSize);

						for (var i = 0; i < deviceCount; i++)
						{
							uint pcbSize = 0;

							// On Window 8 64bit when compiling against .Net > 3.5 using .ToInt32 you will generate an arithmetic overflow. Leave as it is for 32bit/64bit applications
							// Generic overload: the non-generic one returns object, so the cast was
							// an unbox of a possibly-null value (CS8605).
							var rid = Marshal.PtrToStructure<Rawinputdevicelist>(new IntPtr(pRawInputDeviceList.ToInt64() + (dwSize * i)));

							_ = Win32.GetRawInputDeviceInfo(rid.hDevice, RawInputDeviceInfo.RIDI_DEVICENAME, IntPtr.Zero, ref pcbSize);

							if (pcbSize <= 0) { continue; }

							var pData = Marshal.AllocHGlobal((int)pcbSize);

							try
							{
								_ = Win32.GetRawInputDeviceInfo(rid.hDevice, RawInputDeviceInfo.RIDI_DEVICENAME, pData, ref pcbSize);

								var deviceName = Marshal.PtrToStringAnsi(pData) ?? string.Empty;

								if (rid.dwType is not (DeviceType.RimTypekeyboard or DeviceType.RimTypeHid))
								{
									continue;
								}

								var deviceDesc = Win32.GetDeviceDescription(deviceName);

								var dInfo = new KeyPressEvent
								{
									DeviceName = deviceName,
									DeviceHandle = rid.hDevice,
									DeviceType = Win32.GetDeviceType(rid.dwType),
									Name = deviceDesc,
									Source = keyboardNumber++.ToString(CultureInfo.InvariantCulture)
								};

								if (!_deviceList.ContainsKey(rid.hDevice))
								{
									numberOfDevices++;

									_deviceList.Add(rid.hDevice, dInfo);
								}
							}
							finally
							{
								Marshal.FreeHGlobal(pData);
							}
						}
					}
					finally
					{
						Marshal.FreeHGlobal(pRawInputDeviceList);
					}

					NumberOfKeyboards = numberOfDevices;
					Debug.WriteLine("EnumerateDevices() found {0} Keyboard(s)", NumberOfKeyboards);

					return;
				}
			}
			
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	   
		public void ProcessRawInput(IntPtr hdevice)
		{
			if (_deviceList.Count == 0) return;

			var dwSize = 0;

            _ = Win32.GetRawInputData(hdevice, DataCommand.RID_INPUT, IntPtr.Zero, ref dwSize, Marshal.SizeOf(typeof(Rawinputheader)));

			if (dwSize != Win32.GetRawInputData(hdevice, DataCommand.RID_INPUT, out _rawBuffer, ref dwSize, Marshal.SizeOf(typeof (Rawinputheader))))
			{
				Debug.WriteLine("Error getting the rawinput buffer");
				return;
			}

			int virtualKey = _rawBuffer.data.keyboard.VKey;
			int flags = _rawBuffer.data.keyboard.Flags;

			if (virtualKey == Win32.KEYBOARD_OVERRUN_MAKE_CODE) return;

			KeyPressEvent? device;

			// Tested and read inside one lock. EnumerateDevices() clears this dictionary and
			// runs on device-change messages, so a lookup split either side of the lock can find
			// the handle and then fail to fetch it.
			lock (_padLock)
			{
				if (!_deviceList.TryGetValue(_rawBuffer.header.hDevice, out device))
				{
					Debug.WriteLine("Handle: {0} was not in the device list.", _rawBuffer.header.hDevice);

					return;
				}
			}

			var isBreakBitSet = ((flags & Win32.RI_KEY_BREAK) != 0);

			// Copied, not mutated: the dictionary entry outlives this keystroke and is handed to
			// every subscriber.
			var keyPressEvent = device with
			{
				PressState = isBreakBitSet ? KeyPressState.Break : KeyPressState.Make,
				Message = _rawBuffer.data.keyboard.Message,
				VKeyName = KeyMapper.GetMicrosoftKeyName(virtualKey).ToUpperInvariant(),
				VKey = virtualKey
			};

			KeyPressed?.Invoke(this, new RawInputEventArg(keyPressEvent));
		}
	}
}
