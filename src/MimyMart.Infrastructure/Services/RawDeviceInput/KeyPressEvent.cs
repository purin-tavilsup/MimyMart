namespace MimyMart.Infrastructure.Services.RawDeviceInput;

/// <summary>
/// One key event from one device.
///
/// The device fields are enumerated once per device and reused; the key fields belong to a single
/// keystroke. A record rather than a mutable class so RawKeyboard copies the cached device entry
/// per event instead of mutating it — a mutated entry is shared with every handler holding a
/// reference to it, and with the next keystroke from the same device.
/// </summary>
public sealed record KeyPressEvent
{
	private readonly string _source = string.Empty;

	/// <summary>i.e. \\?\HID#VID_045E&amp;PID_00DD&amp;MI_00#8&amp;1eb402&amp;0&amp;0000#{884b96c3-56ef-11d1-bc8c-00a0c91405dd}</summary>
	public string DeviceName { get; init; } = string.Empty;

	/// <summary>KEYBOARD or HID</summary>
	public string DeviceType { get; init; } = string.Empty;

	/// <summary>Handle to the device that sent the input</summary>
	public IntPtr DeviceHandle { get; init; }

	/// <summary>i.e. Microsoft USB Comfort Curve Keyboard 2000 (Mouse and Keyboard Center)</summary>
	public string Name { get; init; } = string.Empty;

	/// <summary>Virtual Key. Corrected for L/R keys (i.e. LSHIFT/RSHIFT) and Zoom</summary>
	public int VKey { get; init; }

	/// <summary>Virtual Key Name. Corrected for L/R keys (i.e. LSHIFT/RSHIFT) and Zoom</summary>
	public string VKeyName { get; init; } = string.Empty;

	/// <summary>WM_KEYDOWN or WM_KEYUP</summary>
	public uint Message { get; init; }

	/// <summary>Whether this is the key going down or coming back up</summary>
	public KeyPressState PressState { get; init; }

	/// <summary>Keyboard_XX</summary>
	public string Source
	{
		get => _source;
		init => _source = $"Keyboard_{value.PadLeft(2, '0')}";
	}

	public override string ToString()
	{
		return $"Device\n DeviceName: {DeviceName}\n DeviceType: {DeviceType}\n DeviceHandle: {DeviceHandle.ToInt64():X}\n Name: {Name}\n";
	}
}
