using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.PayLaterPayments.Queries.GetPayLaterPaymentById;

public record GetPayLaterPaymentByIdQuery(int Id) : IQuery<PayLaterPaymentDto>;