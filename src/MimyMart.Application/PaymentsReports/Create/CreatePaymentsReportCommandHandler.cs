using Microsoft.Extensions.Logging;
using MimyMart.Application.Abstractions;
using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Reports.Repositories;
using MimyMart.Application.Common.Interfaces;
using MimyMart.Application.Common.Models;
using MimyMart.Application.Constants;
using MimyMart.Application.Enums;

namespace MimyMart.Application.PaymentsReports.Create;

public class CreatePaymentsReportCommandHandler : ICommandHandler<CreatePaymentsReportCommand>
{
	private readonly IReportService _reportService;
	private readonly IReportRepository _repository;
	private readonly ILogger<CreatePaymentsReportCommandHandler> _logger;
	private readonly IJsonService _jsonService;
	private readonly IInstalledOsLanguage _installedOsLanguage;

	public CreatePaymentsReportCommandHandler(IReportService reportService, 
											  IReportRepository repository, 
											  ILogger<CreatePaymentsReportCommandHandler> logger, 
											  IJsonService jsonService, 
											  IInstalledOsLanguage installedOsLanguage)
	{
		_reportService = reportService;
		_repository = repository;
		_logger = logger;
		_jsonService = jsonService;
		_installedOsLanguage = installedOsLanguage;
	}

	public async Task Handle(CreatePaymentsReportCommand command, CancellationToken cancellationToken)
	{
		PaymentsReport? report = null;
		
		try
		{
			report = await _reportService.CreatePaymentsReportByInvoiceIdAsync(command.InvoiceId);
			
			await _repository.AddPaymentsReportAsync(report);
		}
		catch (Exception ex)
		{
			await HandleError(ex, report, command.InvoiceId);
		}
	}

	private async Task HandleError(Exception ex, PaymentsReport? report, int invoiceId)
	{
		_logger.LogWarning(ex, 
						   "Error occurred while creating payments report {@Report} for invoice ID {InvoiceId}",
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
	
	private async Task BackupReportAsync(PaymentsReport report)
	{
		var secondaryBackupDirectory = GetSecondaryBackupDirectory();
		
		try
		{
			var tasks = new List<Task>
			{
				BackupReportToFileAsync(report, ReportConstants.PrimaryPaymentsReportBackupDirectory),
				BackupReportToFileAsync(report, secondaryBackupDirectory)
			};

			await Task.WhenAll(tasks);
		}
		catch (AggregateException ae)
		{
			foreach (var e in ae.InnerExceptions)
			{
				_logger.LogWarning(e, "Failed to backup payments report to file. {Message}", e.Message);
			}
		}
	}
	
	private async Task BackupReportToFileAsync(PaymentsReport report, string reportDirectory)
	{
		var fileName = $"report-{report.ReferenceId}";
		var filePath = $"{reportDirectory}{fileName}";
		
		await _jsonService.SaveToFileAsync(report, filePath);
	}
}