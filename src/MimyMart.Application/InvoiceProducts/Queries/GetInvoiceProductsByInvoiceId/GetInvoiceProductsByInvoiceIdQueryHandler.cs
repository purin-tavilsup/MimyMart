﻿using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.InvoiceProducts.Queries.GetInvoiceProductsByInvoiceId;

public class GetInvoiceProductsByInvoiceIdQueryHandler : IQueryHandler<GetInvoiceProductsByInvoiceIdQuery, IEnumerable<InvoiceProductDto>>
{
	private readonly IInvoiceProductRepository _invoiceProductRepository;

	public GetInvoiceProductsByInvoiceIdQueryHandler(IInvoiceProductRepository invoiceProductRepository)
	{
		_invoiceProductRepository = invoiceProductRepository;
	}

	public Task<IEnumerable<InvoiceProductDto>> Handle(GetInvoiceProductsByInvoiceIdQuery query, CancellationToken cancellationToken)
	{
		var results = _invoiceProductRepository.GetByInvoiceId(query.InvoiceId);

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}