using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InvoicePayments.Queries.GetInvoicePaymentsByDateRange;

public record GetInvoicePaymentsByDateRangeQuery(DateOnly StartDate, DateOnly EndDate) : IQuery<IEnumerable<InvoicePaymentDto>>;