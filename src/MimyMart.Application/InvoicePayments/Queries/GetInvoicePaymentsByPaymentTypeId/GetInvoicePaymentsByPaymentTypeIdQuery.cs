using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InvoicePayments.Queries.GetInvoicePaymentsByPaymentTypeId;

public record GetInvoicePaymentsByPaymentTypeIdQuery(int PaymentTypeId) : IQuery<IEnumerable<InvoicePaymentDto>>;