using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InvoicePayments.Queries.GetInvoicePaymentsByDate;

public record GetInvoicePaymentsByDateQuery(DateOnly Date) : IQuery<IEnumerable<InvoicePaymentDto>>;