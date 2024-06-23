using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.Invoices.Queries.GetInvoicesByDate;

public record GetInvoicesByDateQuery(DateOnly Date) : IQuery<IEnumerable<InvoiceDto>>;