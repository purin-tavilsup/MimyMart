﻿using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.PayLaterPayments.Queries.GetPayLaterPaymentByInvoiceId;

public class GetPayLaterPaymentByInvoiceIdQueryHandler : IQueryHandler<GetPayLaterPaymentByInvoiceIdQuery, PayLaterPaymentDto?>
{
	private readonly IPayLaterPaymentRepository _paymentRepository;

	public GetPayLaterPaymentByInvoiceIdQueryHandler(IPayLaterPaymentRepository paymentRepository)
	{
		_paymentRepository = paymentRepository;
	}

	public Task<PayLaterPaymentDto?> Handle(GetPayLaterPaymentByInvoiceIdQuery query, CancellationToken cancellationToken)
	{
		var result = _paymentRepository.GetPayLaterPaymentByInvoiceId(query.InvoiceId);

		return Task.FromResult(result?.ToDto());
	}
}