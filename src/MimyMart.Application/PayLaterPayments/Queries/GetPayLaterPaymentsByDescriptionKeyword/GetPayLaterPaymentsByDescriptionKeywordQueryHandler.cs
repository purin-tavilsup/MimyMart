﻿using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.PayLaterPayments.Queries.GetPayLaterPaymentsByDescriptionKeyword;

public class GetPayLaterPaymentsByDescriptionKeywordQueryHandler : IQueryHandler<GetPayLaterPaymentsByDescriptionKeywordQuery, IEnumerable<PayLaterPaymentDto>>
{
	private readonly IPayLaterPaymentRepository _paymentRepository;

	public GetPayLaterPaymentsByDescriptionKeywordQueryHandler(IPayLaterPaymentRepository paymentRepository)
	{
		_paymentRepository = paymentRepository;
	}

	public Task<IEnumerable<PayLaterPaymentDto>> Handle(GetPayLaterPaymentsByDescriptionKeywordQuery query, CancellationToken cancellationToken)
	{
		var keyword = query.Keyword;
		var results = _paymentRepository.GetPayLaterPaymentsByDescriptionKeyword(keyword);

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}