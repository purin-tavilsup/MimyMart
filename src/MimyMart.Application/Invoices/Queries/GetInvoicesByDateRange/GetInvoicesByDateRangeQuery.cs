using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.Invoices.Queries.GetInvoicesByDateRange;

public record GetInvoicesByDateRangeQuery(DateOnly StartDate, DateOnly EndDate) : IQuery<IEnumerable<InvoiceDto>>;