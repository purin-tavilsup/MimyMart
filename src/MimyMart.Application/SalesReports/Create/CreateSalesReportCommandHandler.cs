using Microsoft.Extensions.Logging;
using MimyMart.Application.Abstractions;
using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Reports.Repositories;
using MimyMart.Application.Common.Interfaces;
using MimyMart.Application.Common.Models;
using MimyMart.Application.Constants;
using MimyMart.Application.Enums;

namespace MimyMart.Application.SalesReports.Create;

public class CreateSalesReportCommandHandler : ICommandHandler<CreateSalesReportCommand>
{
	private readonly IReportService _reportService;
	private readonly IReportRepository _repository;
	private readonly ILogger<CreateSalesReportCommandHandler> _logger;
	private readonly IJsonService _jsonService;
	private readonly IInstalledOsLanguage _installedOsLanguage;

	public CreateSalesReportCommandHandler(IReportRepository repository, 
										   IReportService reportService, 
										   ILogger<CreateSalesReportCommandHandler> logger, 
										   IJsonService jsonService, 
										   IInstalledOsLanguage installedOsLanguage)
	{
		_repository = repository;
		_reportService = reportService;
		_logger = logger;
		_jsonService = jsonService;
		_installedOsLanguage = installedOsLanguage;
	}
	
	public async Task Handle(CreateSalesReportCommand command, CancellationToken cancellationToken)
	{
		SalesReport? report = null;
		
		try
		{
			report = await _reportService.CreateSalesReportByInvoiceIdAsync(command.InvoiceId);
			await _repository.AddSalesReportAsync(report);
		}
		catch (Exception ex)
		{
			await HandleError(ex, report, command.InvoiceId);
		}
	}

	private async Task HandleError(Exception ex, SalesReport? report, int invoiceId)
	{
		_logger.LogWarning(ex, 
						   "Error occurred while creating sales report {@Report} for invoice ID {InvoiceId}",
						   report,
						   invoiceId);

		if (report is not null)
		{
			await BackupReportAsync(report);
		}
	}
	
	private string GetSecondaryBackupDirectory()
	{
		const string directory = ReportConstants.SecondaryPaymentsReportBackupDirectory;

		return _installedOsLanguage.Language == OsLanguage.Thai 
				   ? directory.Replace("My Drive", "ไดรฟ์ของฉัน") 
				   : directory;
	}

	private async Task BackupReportAsync(SalesReport report)
	{
		var secondaryBackupDirectory = GetSecondaryBackupDirectory();
		
		try
		{
			var tasks = new List<Task>
			{
				BackupReportToFileAsync(report, ReportConstants.PrimarySalesReportBackupDirectory),
				BackupReportToFileAsync(report, secondaryBackupDirectory)
			};

			await Task.WhenAll(tasks);
		}
		catch (AggregateException ae)
		{
			foreach (var e in ae.InnerExceptions)
			{
				_logger.LogWarning(e, "Failed to backup sales report to file. {Message}", e.Message);
			}
		}
	}
	
	private async Task BackupReportToFileAsync(SalesReport report, string reportDirectory)
	{
		var fileName = $"report-{report.ReferenceId}";
		var filePath = $"{reportDirectory}{fileName}";
		
		await _jsonService.SaveToFileAsync(report, filePath);
	}
}