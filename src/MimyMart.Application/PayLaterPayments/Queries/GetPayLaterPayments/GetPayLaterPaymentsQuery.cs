using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.PayLaterPayments.Queries.GetPayLaterPayments;

public record GetPayLaterPaymentsQuery() : IQuery<IEnumerable<PayLaterPaymentDto>>;