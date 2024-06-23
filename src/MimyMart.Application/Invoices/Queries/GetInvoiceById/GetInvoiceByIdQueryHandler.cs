using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Common.Interfaces;

namespace MimyMart.Application.Invoices.Queries.GetInvoiceById;

public class GetInvoiceByIdQueryHandler : IQueryHandler<GetInvoiceByIdQuery, InvoiceDto>
{
	private readonly IInvoiceRepository _invoiceRepository;

	public GetInvoiceByIdQueryHandler(IInvoiceRepository invoiceRepository)
	{
		_invoiceRepository = invoiceRepository;
	}

	public Task<InvoiceDto> Handle(GetInvoiceByIdQuery query, CancellationToken cancellationToken)
	{
		var result = _invoiceRepository.GetById(query.Id);

		return Task.FromResult(result.ToDto());
	}
}