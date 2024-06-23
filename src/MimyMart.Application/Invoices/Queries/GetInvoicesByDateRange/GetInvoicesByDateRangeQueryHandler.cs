using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Common.Interfaces;

namespace MimyMart.Application.Invoices.Queries.GetInvoicesByDateRange;

public class GetInvoicesByDateRangeQueryHandler : IQueryHandler<GetInvoicesByDateRangeQuery, IEnumerable<InvoiceDto>>
{
	private readonly IInvoiceRepository _invoiceRepository;

	public GetInvoicesByDateRangeQueryHandler(IInvoiceRepository invoiceRepository)
	{
		_invoiceRepository = invoiceRepository;
	}

	public Task<IEnumerable<InvoiceDto>> Handle(GetInvoicesByDateRangeQuery query, CancellationToken cancellationToken)
	{
		var results = _invoiceRepository.GetByDateRange(query.StartDate, query.EndDate);

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}