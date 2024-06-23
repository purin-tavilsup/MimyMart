using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.PayLaterPayments.Queries.GetPayLaterPaymentById;

public class GetPayLaterPaymentByIdQueryHandler : IQueryHandler<GetPayLaterPaymentByIdQuery, PayLaterPaymentDto>
{
	private readonly IPayLaterPaymentRepository _paymentRepository;

	public GetPayLaterPaymentByIdQueryHandler(IPayLaterPaymentRepository paymentRepository)
	{
		_paymentRepository = paymentRepository;
	}

	public Task<PayLaterPaymentDto> Handle(GetPayLaterPaymentByIdQuery query, CancellationToken cancellationToken)
	{
		var result = _paymentRepository.GetById(query.Id);

		return Task.FromResult(result.ToDto());
	}
}