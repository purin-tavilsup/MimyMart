using MediatR;
using MimyMart.Application.Common.Enums;
using MimyMart.Application.Common.Extensions;
using MimyMart.Application.Common.Interfaces;
using MimyMart.Application.Common.Models;
using MimyMart.Application.InvoicePayments;
using MimyMart.Application.InvoicePayments.Queries.GetInvoicePaymentsByDateRange;
using MimyMart.Application.InvoicePayments.Queries.GetInvoicePaymentsByInvoiceId;
using MimyMart.Application.InvoiceProducts;
using MimyMart.Application.InvoiceProducts.Queries.GetInvoiceProductsByDate;
using MimyMart.Application.InvoiceProducts.Queries.GetInvoiceProductsByDateRange;
using MimyMart.Application.InvoiceProducts.Queries.GetInvoiceProductsByInvoiceId;
using MimyMart.Application.Invoices;
using MimyMart.Application.Invoices.Queries.GetInvoicesByDateRange;

namespace MimyMart.Infrastructure.Services;

public class ReportService : IReportService
{
	private readonly IMediator _mediator;

	public ReportService(IMediator mediator)
	{
		_mediator = mediator;
	}

	public async Task<IEnumerable<InvoiceDto>> GetInvoicesByPeriodAsync(TimePeriod period)
	{
		var dateRange = period.ToDateRange();

		return await GetInvoicesByDateRangeAsync(dateRange.StartDate, dateRange.EndDate);
	}

	public async Task<SalesSummary> CreateSalesSummaryByPeriodAsync(TimePeriod period)
	{
		var dateRange = period.ToDateRange();

		return await CreateSalesSummaryByDateRangeAsync(dateRange.StartDate, dateRange.EndDate);
	}

	public async Task<PaymentsSummary> CreatePaymentsSummaryByPeriodAsync(TimePeriod period)
	{
		var dateRange = period.ToDateRange();

		return await CreatePaymentsSummaryByDateRangeAsync(dateRange.StartDate, dateRange.EndDate);
	}

	public async Task<SalesSummary> CreateSalesSummaryByDateRangeAsync(DateOnly startDate, DateOnly endDate)
	{
		var products = await GetInvoiceProductsByDateRangeAsync(startDate, endDate);

		return CreateSalesSummary(products.ToList());
	}

	public async Task<SalesReport> CreateSalesReportByInvoiceIdAsync(int invoiceId)
	{
		var id = Guid.NewGuid();
		var created = DateTime.Now;
		var summary = await CreateSalesSummaryByInvoiceIdAsync(invoiceId);

		return summary.ToReport(id, created, invoiceId);
	}

	public async Task<PaymentsReport> CreatePaymentsReportByInvoiceIdAsync(int invoiceId)
	{
		var id = Guid.NewGuid();
		var created = DateTime.Now;
		var summary = await CreatePaymentsSummaryByInvoiceIdAsync(invoiceId);
		
		return summary.ToReport(id, created, invoiceId);
	}
	
	private async Task<SalesSummary> CreateSalesSummaryByInvoiceIdAsync(int invoiceId)
	{
		var products = await GetInvoiceProductsByInvoiceIdAsync(invoiceId);
		
		return CreateSalesSummary(products.ToList());
	}

	private async Task<PaymentsSummary> CreatePaymentsSummaryByInvoiceIdAsync(int invoiceId)
	{
		var payments = await GetPaymentsByInvoiceIdAsync(invoiceId);

		return CreatePaymentsSummary(payments);
	}

	private static SalesSummary CreateSalesSummary(IReadOnlyList<InvoiceProductDto> products)
	{
		var invoicesTotal = 0m;

		foreach (var product in products)
		{
			var productTotal = !product.IsGroupProduct 
								   ? product.UnitPrice * product.Quantity 
								   : product.GroupPrice;

			invoicesTotal += productTotal;
		}

		return new SalesSummary
		{
			InvoiceTotal = invoicesTotal
		};
	}

	public async Task<PaymentsSummary> CreatePaymentsSummaryByDateRangeAsync(DateOnly startDate, DateOnly endDate)
	{
		var payments = await GetPaymentsByDateRangeAsync(startDate, endDate);

		return CreatePaymentsSummary(payments);
	}

	private static PaymentsSummary CreatePaymentsSummary(IEnumerable<InvoicePaymentDto> payments)
	{
		var moneyTransferTotal = 0m;
		
		foreach (var payment in payments)
		{
			var amount = payment.Amount;

			switch (payment.PaymentTypeId)
			{
				case (int) PaymentType.MoneyTransfer:
					moneyTransferTotal += amount;
					break;
			}
		}

		return new PaymentsSummary
		{
			MoneyTransferTotal = moneyTransferTotal
		};
	}

	public async Task<IEnumerable<InvoiceDto>> GetInvoicesByDateRangeAsync(DateOnly startDate, DateOnly endDate)
	{
		return await _mediator.Send(new GetInvoicesByDateRangeQuery(startDate, endDate));
    }

	public async Task<IEnumerable<InvoiceProductDto>> GetInvoiceProductsByDateAsync(DateOnly date)
	{
		return await _mediator.Send(new GetInvoiceProductsByDateQuery(date));
	}

	public async Task<IEnumerable<InvoiceProductDto>> GetInvoiceProductsByDateRangeAsync(DateOnly startDate, DateOnly endDate)
	{
		return await _mediator.Send(new GetInvoiceProductsByDateRangeQuery(startDate, endDate));
	}

	public async Task<IEnumerable<InvoiceProductDto>> GetInvoiceProductsByInvoiceIdAsync(int invoiceId)
	{
		return await _mediator.Send(new GetInvoiceProductsByInvoiceIdQuery(invoiceId));
	}

	private async Task<IEnumerable<InvoicePaymentDto>> GetPaymentsByDateRangeAsync(DateOnly startDate, DateOnly endDate)
	{
		return await _mediator.Send(new GetInvoicePaymentsByDateRangeQuery(startDate, endDate));
	}

	public async Task<IEnumerable<InvoicePaymentDto>> GetPaymentsByInvoiceIdAsync(int invoiceId)
	{
		return await _mediator.Send(new GetInvoicePaymentsByInvoiceIdQuery(invoiceId));
	}
}