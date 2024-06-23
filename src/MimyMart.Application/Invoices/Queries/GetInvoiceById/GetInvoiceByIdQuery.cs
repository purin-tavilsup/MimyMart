using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.Invoices.Queries.GetInvoiceById;

public record GetInvoiceByIdQuery(int Id) : IQuery<InvoiceDto>;