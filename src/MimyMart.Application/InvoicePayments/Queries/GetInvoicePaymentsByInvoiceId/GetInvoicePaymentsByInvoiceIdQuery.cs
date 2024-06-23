using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InvoicePayments.Queries.GetInvoicePaymentsByInvoiceId;

public record GetInvoicePaymentsByInvoiceIdQuery(int InvoiceId) : IQuery<IEnumerable<InvoicePaymentDto>>;