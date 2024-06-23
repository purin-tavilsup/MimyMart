using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.PayLaterPayments.Queries.GetPayLaterPaymentByInvoiceId;

public record GetPayLaterPaymentByInvoiceIdQuery(int InvoiceId) : IQuery<PayLaterPaymentDto?>;