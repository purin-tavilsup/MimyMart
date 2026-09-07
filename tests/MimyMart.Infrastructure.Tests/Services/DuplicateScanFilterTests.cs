using FluentAssertions;
using MimyMart.Application.Common.Interfaces;
using MimyMart.Infrastructure.Services;
using Moq;
using Xunit;

namespace MimyMart.Infrastructure.Tests.Services;

public class DuplicateScanFilterTests
{
	private const string Barcode = "4057599007718";
	private const string AnotherBarcode = "620584635384";

	private static readonly DateTime Start = new(2026, 7, 28, 9, 0, 0);

	private DateTime _now = Start;

	[Fact]
	public void ShouldAccept_WithTheFirstScan_ShouldReturnTrue()
	{
		var filter = CreateFilter();

		filter.ShouldAccept(Barcode)
			  .Should()
			  .BeTrue();
	}

	[Fact]
	public void ShouldAccept_WithTheSameBarcodeInsideTheWindow_ShouldReturnFalse()
	{
		// A product left in a presentation scanner's field of view re-reads within milliseconds
		var filter = CreateFilter();

		filter.ShouldAccept(Barcode);

		Advance(200);

		filter.ShouldAccept(Barcode)
			  .Should()
			  .BeFalse();
	}

	[Fact]
	public void ShouldAccept_WithTheSameBarcodeAfterTheWindow_ShouldReturnTrue()
	{
		// Presenting the same item again deliberately must still register
		var filter = CreateFilter();

		filter.ShouldAccept(Barcode);

		Advance(600);

		filter.ShouldAccept(Barcode)
			  .Should()
			  .BeTrue();
	}

	[Fact]
	public void ShouldAccept_WithADifferentBarcodeInsideTheWindow_ShouldReturnTrue()
	{
		// Scanning through a basket quickly must never be suppressed
		var filter = CreateFilter();

		filter.ShouldAccept(Barcode);

		Advance(50);

		filter.ShouldAccept(AnotherBarcode)
			  .Should()
			  .BeTrue();
	}

	[Fact]
	public void ShouldAccept_WhileAnItemKeepsReReading_ShouldKeepRejectingUntilItIsRemoved()
	{
		// The window runs from the last read, accepted or not, so an item that keeps re-reading
		// every 300ms stays suppressed instead of slipping one through every 500ms.
		var filter = CreateFilter();

		filter.ShouldAccept(Barcode)
			  .Should()
			  .BeTrue();

		Advance(300);

		filter.ShouldAccept(Barcode)
			  .Should()
			  .BeFalse();

		Advance(300);

		filter.ShouldAccept(Barcode)
			  .Should()
			  .BeFalse();

		// Item removed, then presented again
		Advance(600);

		filter.ShouldAccept(Barcode)
			  .Should()
			  .BeTrue();
	}

	[Fact]
	public void ShouldAccept_AtExactlyTheWindowBoundary_ShouldReturnTrue()
	{
		var filter = CreateFilter();

		filter.ShouldAccept(Barcode);

		Advance(500);

		filter.ShouldAccept(Barcode)
			  .Should()
			  .BeTrue();
	}

	private void Advance(int milliseconds)
	{
		_now = _now.AddMilliseconds(milliseconds);
	}

	private DuplicateScanFilter CreateFilter()
	{
		var dateTimeService = new Mock<IDateTimeService>();

		dateTimeService.Setup(service => service.Now)
					   .Returns(() => _now);

		return new DuplicateScanFilter(dateTimeService.Object);
	}
}
