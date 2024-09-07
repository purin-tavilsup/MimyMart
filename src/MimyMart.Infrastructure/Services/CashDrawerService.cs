using System.Drawing.Printing;
using System.Runtime.Versioning;
using Microsoft.Extensions.Logging;
using MimyMart.Application.Common.Interfaces;

namespace MimyMart.Infrastructure.Services;

[type:SupportedOSPlatform("windows")]
public class CashDrawerService : ICashDrawerService
{
	private readonly PrintDocument _printDocument;
	private readonly ILogger<CashDrawerService> _logger;
	private readonly Font _textFont;
	private readonly SolidBrush _brush;
	private const string PrinterName = "XP-58";
	private const string FontFamilyName = "FC Subject [Non-commercial] Reg";
	private const int TextFontSize = 7;
	
	public CashDrawerService(ILogger<CashDrawerService> logger)
	{
		_logger = logger;
		_textFont = new Font(FontFamilyName, TextFontSize);
		_brush = new SolidBrush(Color.Black);
		_printDocument = new PrintDocument();
		_printDocument.PrinterSettings.PrinterName = PrinterName;
		_printDocument.PrintPage += PrintPageHandler;
	}

	public void OpenCashDrawer()
	{
		_logger.LogInformation("Opening Cash Drawer");
		
		_printDocument.Print();
	}

	private void PrintPageHandler(object sender, PrintPageEventArgs e)
	{
		_logger.LogDebug("Printing Dummy Page");
	}
}