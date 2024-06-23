using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.PayLaterPayments.Queries.GetPayLaterPaymentsByDescriptionKeyword;

public record GetPayLaterPaymentsByDescriptionKeywordQuery(string Keyword) : IQuery<IEnumerable<PayLaterPaymentDto>>;