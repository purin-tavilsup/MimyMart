using System.Text;

namespace MimyMart.Infrastructure.Services;

/// <summary>
/// Accumulates the keystrokes of one scan and hands the finished barcode over in a single step that
/// also empties the buffer.
///
/// Emptying it on the way out is the whole point of the type. Publishing a barcode is synchronous,
/// and a subscriber that opens a modal dialog runs a nested message loop which keeps delivering raw
/// input — so the next scan's keystrokes arrive before the publish returns. A buffer cleared
/// *after* publishing is still holding the barcode just published when they do, and the next
/// ENTER then publishes both barcodes concatenated. That reached the log as
/// 620584635384620584635384 against a scanner that had cleanly sent two separate twelve-digit
/// scans.
/// </summary>
public sealed class BarcodeScanBuffer
{
	private readonly StringBuilder _characters = new();

	public void Append(string characters)
	{
		_characters.Append(characters);
	}

	/// <summary>
	/// True when a scan had been buffered, in which case <paramref name="barcode"/> holds it and
	/// the buffer is left empty ready for the next scan.
	/// </summary>
	public bool TryTake(out string barcode)
	{
		barcode = _characters.ToString();

		_characters.Clear();

		return barcode.Length > 0;
	}
}
