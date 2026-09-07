namespace MimyMart.Windows.Forms.UI;

/// <summary>
/// Lets one scan at a time through a panel's barcode handler.
///
/// Barcodes arrive on the UI thread: raw input is delivered inside WndProc and the event
/// aggregator publishes synchronously on the publishing thread. When a handler opens a modal
/// dialog, ShowDialog runs a nested message loop that keeps dispatching WM_INPUT — so the next
/// scan re-enters the handler while the dialog is still open, and calling ShowDialog again on the
/// same singleton form throws InvalidOperationException and takes the app down.
///
/// A plain bool is enough because every caller is on the UI thread; this is reentrancy, not
/// concurrency.
/// </summary>
public sealed class BarcodeScanGate
{
	private bool _isHandlingScan;

	/// <summary>
	/// True if the caller may handle this scan, in which case it must call <see cref="Exit"/> from
	/// a finally block. False if a scan is already being handled and this one should be dropped.
	/// </summary>
	public bool TryEnter()
	{
		if (_isHandlingScan)
		{
			return false;
		}

		_isHandlingScan = true;

		return true;
	}

	public void Exit()
	{
		_isHandlingScan = false;
	}
}
