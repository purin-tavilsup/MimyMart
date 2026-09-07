using System.Diagnostics;
using System.Runtime.Versioning;
using System.Text;
using Microsoft.Extensions.Logging;
using MimyMart.Application.Common.Enums;
using MimyMart.Application.Common.Interfaces;
using MimyMart.Application.Events;
using MimyMart.Infrastructure.Services.RawDeviceInput;
using Prism.Events;

namespace MimyMart.Infrastructure.Services;

[type: SupportedOSPlatform("windows")]
public class RawInputDeviceService : IRawInputDeviceService
{
	private readonly IEventAggregator _eventAggregator;
	private readonly IStoreConfigurationService _storeConfigurationService;
	private readonly ILogger<RawInputDeviceService> _logger;
	private readonly DuplicateScanFilter _duplicateScanFilter;
	private RawInputDeviceMode _mode;
	private RawInput? _rawInput;
	private BarcodeScanBuffer _scanBuffer;
	private byte[] _keyState;
	private string _barcodeScannerDeviceName = string.Empty;

	public RawInputDeviceService(IEventAggregator eventAggregator,
								 IStoreConfigurationService storeConfigurationService,
								 IDateTimeService dateTimeService,
								 ILogger<RawInputDeviceService> logger)
	{
		_eventAggregator = eventAggregator;
		_storeConfigurationService = storeConfigurationService;
		_duplicateScanFilter = new DuplicateScanFilter(dateTimeService);
		_logger = logger;
		_scanBuffer = new BarcodeScanBuffer();
		_keyState = new byte[256];
		_mode = RawInputDeviceMode.GetInputValue;
	}

	public void Start(IntPtr handle)
	{
		Stop();
		LoadConfiguration();

		_rawInput = new RawInput(handle, captureOnlyInForeground: true, _barcodeScannerDeviceName);
		_scanBuffer = new BarcodeScanBuffer();
		_keyState = new byte[256];

		_rawInput.AddMessageFilter();
		_rawInput.KeyPressed += OnKeyPressed;

		_logger.LogInformation("Raw input device service started");
	}

	public void LoadConfiguration()
	{
		var config = _storeConfigurationService.Get();

		_barcodeScannerDeviceName = config.BarcodeScannerDeviceName ?? string.Empty;
	}

	public void Stop()
	{
		if (_rawInput is null)
			return;

		_rawInput.KeyPressed -= OnKeyPressed;
		_rawInput.Dispose();
		_rawInput = null;

		_logger.LogInformation("Raw input device service stopped");
	}

	public void SetMode(RawInputDeviceMode mode)
	{
		_mode = mode;
	}

    private void OnKeyPressed(object sender, RawInputEventArg e)
	{
		LogScannerKeystroke(e.KeyPressEvent);

		// RawInput will always produce 2 events for each key: one going down (Make) and one
		// coming back up (Break). The first event can be skipped.
		if (e.KeyPressEvent.PressState == KeyPressState.Make)
		{
			return;
		}

		if (_mode == RawInputDeviceMode.GetInputValue)
		{
			ProcessRawInput(e.KeyPressEvent);

			return;
		}

		if (_mode == RawInputDeviceMode.GetDeviceName)
		{
			ProcessDeviceName(e.KeyPressEvent);
		}
	}

	private void ProcessRawInput(KeyPressEvent keyPressEvent)
	{
		if (keyPressEvent.DeviceName == _barcodeScannerDeviceName)
		{
			ProcessScannerInput(keyPressEvent);
		}
	}

	private void ProcessScannerInput(KeyPressEvent keyPressEvent)
	{
		var virtualKey = (ushort) keyPressEvent.VKey;

		// All keys except ENTER will be translated to characters and stored in buffer
		if (!IsEnterKey(keyPressEvent))
		{
			// Skip keys that have no translation
			if (Win32.MapVirtualKeyToCharacter(virtualKey) == 0)
			{
				// Set high-order bit to '1' (0x80 or 1000 0000) for Key Down
				_keyState[virtualKey] = 0x80;

				return;
			}

			var buffer = new StringBuilder(2);

			var numberOfCharacters = Win32.TranslateVirtualKeyToUnicode(virtualKey, _keyState, buffer);

			if (numberOfCharacters > 0)
			{
				var characters = buffer.ToString(0, numberOfCharacters);

				_scanBuffer.Append(characters);
			}

			// Reset
			_keyState = new byte[256];

			return;
		}

		// Reaching here means the key was ENTER, so the scan is complete. Taking the barcode empties
		// the buffer before anything is published, which is what keeps a scan that arrives during a
		// subscriber's modal dialog from being appended to the one already on its way out.
		if (!_scanBuffer.TryTake(out var barcode))
		{
			return;
		}

		_keyState = new byte[256];

		PublishBarcode(barcode);
	}

	private void PublishBarcode(string barcode)
	{
		if (!_duplicateScanFilter.ShouldAccept(barcode))
		{
			_logger.LogDebug("Suppressed a repeat read of {Barcode}", barcode);

			return;
		}

		// Timed because subscribers run synchronously on this, the UI, thread. If a scan's trailing
		// keystroke is still arriving while they block, the scanner can miss the transfer and
		// report it with an error tone even though the barcode itself landed intact.
		var stopwatch = Stopwatch.StartNew();

		_eventAggregator.GetEvent<BarcodeReceivedEvent>().Publish(barcode);

		_logger.LogDebug("Published {Barcode}; subscribers held the UI thread for {ElapsedMilliseconds} ms",
						 barcode,
						 stopwatch.ElapsedMilliseconds);
	}

	/// <summary>
	/// Diagnostic trace of everything the paired scanner sends, including the Make events the
	/// handler discards. Filtered to the configured device so ordinary typing at the till is never
	/// written to the log.
	/// </summary>
	private void LogScannerKeystroke(KeyPressEvent keyPressEvent)
	{
		if (keyPressEvent.DeviceName != _barcodeScannerDeviceName)
			return;

		_logger.LogDebug("Scanner sent {PressState} VKey=0x{VKey:X2} ({VKeyName})",
						 keyPressEvent.PressState,
						 keyPressEvent.VKey,
						 keyPressEvent.VKeyName);
	}

	/// <summary>
	/// Matched on the virtual-key code rather than the display name: that name comes out of a
	/// 200-case switch and is then uppercased, and ENTER is the one key whose match ends a scan —
	/// if it ever stops reading "ENTER", scanning silently stops working altogether.
	/// </summary>
	private static bool IsEnterKey(KeyPressEvent keyPressEvent)
	{
		return keyPressEvent.VKey == Win32.VK_RETURN;
	}

	private void ProcessDeviceName(KeyPressEvent keyPressEvent)
	{
		// Only the last key (ENTER) is needed for getting device name
		if (!IsEnterKey(keyPressEvent))
		{
			return;
		}

		var deviceName = keyPressEvent.DeviceName;

		_eventAggregator.GetEvent<RawInputDeviceNameReceivedEvent>().Publish(deviceName);

		// Reset mode back to default
		_mode = RawInputDeviceMode.GetInputValue;
	}
}