using MimyMart.Application.Common.Enums;
using MimyMart.Application.Common.Models;
using MimyMart.Application.InvoicePayments;
using MimyMart.Application.InvoiceProducts;
using MimyMart.Application.Invoices;

namespace MimyMart.Application.Common.Interfaces;

public interface IReportService
{
	Task<SalesSummary> CreateSalesSummaryByPeriodAsync(TimePeriod period);

	Task<SalesSummary> CreateSalesSummaryByDateRangeAsync(DateOnly startDate, DateOnly endDate);

	Task<PaymentsSummary> CreatePaymentsSummaryByPeriodAsync(TimePeriod period);

	Task<PaymentsSummary> CreatePaymentsSummaryByDateRangeAsync(DateOnly startDate, DateOnly endDate);

	Task<IEnumerable<InvoiceDto>> GetInvoicesByPeriodAsync(TimePeriod period);

	Task<IEnumerable<InvoiceDto>> GetInvoicesByDateRangeAsync(DateOnly startDate, DateOnly endDate);

	Task<IEnumerable<InvoiceProductDto>> GetInvoiceProductsByDateAsync(DateOnly date);

	Task<IEnumerable<InvoiceProductDto>> GetInvoiceProductsByDateRangeAsync(DateOnly startDate, DateOnly endDate);

	Task<IEnumerable<InvoiceProductDto>> GetInvoiceProductsByInvoiceIdAsync(int invoiceId);

	Task<IEnumerable<InvoicePaymentDto>> GetPaymentsByInvoiceIdAsync(int invoiceId);

	Task<SalesReport> CreateSalesReportByInvoiceIdAsync(int invoiceId);

	Task<PaymentsReport> CreatePaymentsReportByInvoiceIdAsync(int invoiceId);
}