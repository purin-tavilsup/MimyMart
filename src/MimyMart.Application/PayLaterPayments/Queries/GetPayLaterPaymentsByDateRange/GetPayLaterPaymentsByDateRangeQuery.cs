using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.PayLaterPayments.Queries.GetPayLaterPaymentsByDateRange;

public record GetPayLaterPaymentsByDateRangeQuery(DateOnly StartDate, DateOnly EndDate) : IQuery<IEnumerable<PayLaterPaymentDto>>;