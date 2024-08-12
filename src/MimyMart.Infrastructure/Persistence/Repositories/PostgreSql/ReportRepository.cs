using Dapper;
using Microsoft.Extensions.Logging;
using MimyMart.Application.Abstractions.Reports.Repositories;
using MimyMart.Application.Common.Models;

namespace MimyMart.Infrastructure.Persistence.Repositories.PostgreSql;

public class ReportRepository : IReportRepository
{
	private readonly IReportDbConnectionProvider _dbConnectionProvider;
	private readonly ILogger<ReportRepository> _logger;

	public ReportRepository(IReportDbConnectionProvider dbConnectionProvider, 
							ILogger<ReportRepository> logger)
	{
		_dbConnectionProvider = dbConnectionProvider;
		_logger = logger;
	}

	public async Task AddSalesReportAsync(SalesReport report)
	{
		try
		{
			using var connection = _dbConnectionProvider.CreateConnection();
			connection.Open();
		
			const string sqlCommand = 
				"""
				INSERT INTO mimy_mart_report.sales_report
					(id,
					 created,
					 reference_id,
					 invoice_total)
				VALUES
					(@id,
					 @created,
					 @referenceId,
					 @invoiceTotal);
				""";
		
			var sqlParameters = new
			{
				id = report.Id,
				created = report.Created,
				referenceId = report.ReferenceId,
				invoiceTotal = report.InvoiceTotal
			};

			await connection.ExecuteAsync(sqlCommand, sqlParameters);
		}
		catch (Exception ex)
		{
			_logger.LogWarning(ex, 
							   "Error occurred while adding sales report {@Report} to report database for invoice ID {InvoiceId}",
							   report,
							   report.ReferenceId);

			throw;
		}
	}

	public async Task AddPaymentsReportAsync(PaymentsReport report)
	{
		try
		{
			using var connection = _dbConnectionProvider.CreateConnection();
			connection.Open();
		
			const string sqlCommand = 
				"""
				INSERT INTO mimy_mart_report.payments_report
					(id,
					 created,
					 reference_id,
					 money_transfer_total)
				VALUES
					(@id,
					 @created,
					 @referenceId,
					 @moneyTransferTotal);
				""";
		
			var sqlParameters = new
			{
				id = report.Id,
				created = report.Created,
				referenceId = report.ReferenceId,
				moneyTransferTotal = report.MoneyTransferTotal
			};

			await connection.ExecuteAsync(sqlCommand, sqlParameters);
		}
		catch (Exception ex)
		{
			_logger.LogWarning(ex, 
							   "Error occurred while adding payments report {@Report} to report database for invoice ID {InvoiceId}",
							   report,
							   report.ReferenceId);

			throw;
		}
	}
}