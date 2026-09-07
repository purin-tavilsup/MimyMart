using FluentAssertions;
using MimyMart.Infrastructure.Services;
using Xunit;

namespace MimyMart.Infrastructure.Tests.Services;

public class BarcodeScanBufferTests
{
	private const string Barcode = "620584635384";
	private const string AnotherBarcode = "8858971511085";

	[Fact]
	public void TryTake_WithNothingScanned_ShouldReturnFalse()
	{
		var buffer = new BarcodeScanBuffer();

		buffer.TryTake(out _)
			  .Should()
			  .BeFalse();
	}

	[Fact]
	public void TryTake_AfterAScanCompletes_ShouldReturnTheBarcode()
	{
		var buffer = new BarcodeScanBuffer();

		AppendScan(buffer, Barcode);

		buffer.TryTake(out var barcode)
			  .Should()
			  .BeTrue();

		barcode.Should()
			   .Be(Barcode);
	}

	[Fact]
	public void TryTake_WhenCalledTwiceForOneScan_ShouldNotReturnTheBarcodeAgain()
	{
		var buffer = new BarcodeScanBuffer();

		AppendScan(buffer, Barcode);

		buffer.TryTake(out _);

		buffer.TryTake(out _)
			  .Should()
			  .BeFalse();
	}

	[Fact]
	public void TryTake_WithASecondScanArrivingBeforeTheFirstIsPublished_ShouldKeepTheTwoScansSeparate()
	{
		// This is the defect the log caught. Publishing is synchronous and a subscriber's modal
		// dialog pumps messages, so the next scan's keys arrive before the publish returns. Taking
		// a scan must therefore empty the buffer in the same step, or the second scan publishes
		// both barcodes concatenated — 620584635384620584635384 in the real log.
		var buffer = new BarcodeScanBuffer();

		AppendScan(buffer, Barcode);

		buffer.TryTake(out var published)
			  .Should()
			  .BeTrue();

		// Arrives while the caller is still handling `published`
		AppendScan(buffer, AnotherBarcode);

		buffer.TryTake(out var next)
			  .Should()
			  .BeTrue();

		published.Should()
				 .Be(Barcode);

		next.Should()
			.Be(AnotherBarcode);
	}

	[Fact]
	public void TryTake_WithTheSameBarcodeScannedTwice_ShouldReturnItBothTimes()
	{
		// Two of the same item is a real purchase; only the timing filter may suppress a repeat
		var buffer = new BarcodeScanBuffer();

		AppendScan(buffer, Barcode);

		buffer.TryTake(out var first);

		AppendScan(buffer, Barcode);

		buffer.TryTake(out var second);

		first.Should()
			 .Be(Barcode);

		second.Should()
			  .Be(Barcode);
	}

	private static void AppendScan(BarcodeScanBuffer buffer, string barcode)
	{
		// The service appends one translated keystroke at a time
		foreach (var character in barcode)
		{
			buffer.Append(character.ToString());
		}
	}
}
