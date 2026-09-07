using System.Runtime.InteropServices;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using MimyMart.Application.Common.Interfaces;
using MimyMart.Application.Common.Models;
using MimyMart.Infrastructure.Services;
using Moq;
using Prism.Events;
using Xunit;

namespace MimyMart.Windows.Forms.Tests.Services;

/// <summary>
/// Start() subclasses the supplied window so the barcode scanner's WM_INPUT messages can be
/// intercepted. Stop() must undo that: a subclass left behind outlives the form it was attached
/// to, and cleanup then falls to a finalizer that calls WinForms APIs off the UI thread.
/// </summary>
public class RawInputDeviceServiceTests
{
	private const int GwlpWndProc = -4;

	[Fact]
	public void Stop_AfterStart_ShouldRestoreTheWindowProcedureThatStartSubclassed()
	{
		using var form = new System.Windows.Forms.Form();
		var service = CreateService();
		var originalWindowProc = GetWindowLongPtr(form.Handle, GwlpWndProc);

		service.Start(form.Handle);
		var subclassedWindowProc = GetWindowLongPtr(form.Handle, GwlpWndProc);
		service.Stop();

		subclassedWindowProc.Should()
							.NotBe(originalWindowProc, "Start subclasses the window to receive WM_INPUT");
		GetWindowLongPtr(form.Handle, GwlpWndProc)
			.Should()
			.Be(originalWindowProc, "Stop must release the window it subclassed");
	}

	private static RawInputDeviceService CreateService()
	{
		var storeConfigurationService = new Mock<IStoreConfigurationService>();

		storeConfigurationService.Setup(configurationService => configurationService.Get())
								 .Returns(new StoreConfiguration { BarcodeScannerDeviceName = string.Empty });

		return new RawInputDeviceService(new EventAggregator(),
										 storeConfigurationService.Object,
										 new Mock<IDateTimeService>().Object,
										 new Mock<ILogger<RawInputDeviceService>>().Object);
	}

	[DllImport("user32.dll", EntryPoint = "GetWindowLongPtrW", SetLastError = true)]
	private static extern IntPtr GetWindowLongPtr(IntPtr windowHandle, int index);
}
