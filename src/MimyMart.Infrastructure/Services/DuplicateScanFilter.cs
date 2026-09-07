using MimyMart.Application.Common.Interfaces;

namespace MimyMart.Infrastructure.Services;

/// <summary>
/// Drops the repeat reads a hands-free presentation scanner produces while a product sits in its
/// field of view. Those scanners have no trigger, so one read is not one deliberate act the way it
/// is on a handheld — the same barcode arrives again every few hundred milliseconds until the item
/// is taken away, and each one would otherwise be charged for.
///
/// Scanner firmware usually calls the same thing a reread delay; raising it there is the better
/// cure, and this is the safety net for when it cannot be set or is lost to a factory reset.
/// </summary>
public sealed class DuplicateScanFilter
{
	/// <summary>
	/// Short on purpose. A repeat read arrives within a few hundred milliseconds, whereas moving
	/// one item out of the scanner's view and presenting the next takes far longer — so two
	/// genuinely separate items cannot fall inside this window, while a lingering item cannot
	/// escape it.
	/// </summary>
	private static readonly TimeSpan SuppressionWindow = TimeSpan.FromMilliseconds(500);

	private readonly IDateTimeService _dateTimeService;

	private string _lastBarcode = string.Empty;
	private DateTime _lastScannedAt = DateTime.MinValue;

	public DuplicateScanFilter(IDateTimeService dateTimeService)
	{
		_dateTimeService = dateTimeService;
	}

	/// <summary>
	/// True if this scan is a new read rather than a repeat of the one before it.
	/// </summary>
	public bool ShouldAccept(string barcode)
	{
		var now = _dateTimeService.Now;
		var isRepeat = barcode == _lastBarcode && now - _lastScannedAt < SuppressionWindow;

		// Stamped whether or not the scan was accepted, so an item that keeps re-reading stays
		// suppressed for as long as it is presented, rather than letting one through per window.
		_lastBarcode = barcode;
		_lastScannedAt = now;

		return !isRepeat;
	}
}
