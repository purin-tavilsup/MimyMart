using MimyMart.Application.Common.Models;

namespace MimyMart.Application.Abstractions.Reports.Repositories;

public interface IReportRepository
{
	Task AddSalesReportAsync(SalesReport report);

	Task AddPaymentsReportAsync(PaymentsReport report);
}