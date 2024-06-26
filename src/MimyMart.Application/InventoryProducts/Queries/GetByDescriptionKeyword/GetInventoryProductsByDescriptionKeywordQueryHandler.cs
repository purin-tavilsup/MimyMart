﻿using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.InventoryProducts.Queries.GetByDescriptionKeyword;

public class GetInventoryProductsByDescriptionKeywordQueryHandler : IQueryHandler<GetInventoryProductsByDescriptionKeywordQuery, IEnumerable<InventoryProductDto>>
{
	private readonly IInventoryProductRepository _productRepository;

	public GetInventoryProductsByDescriptionKeywordQueryHandler(IInventoryProductRepository productRepository)
	{
		_productRepository = productRepository;
	}

	public Task<IEnumerable<InventoryProductDto>> Handle(GetInventoryProductsByDescriptionKeywordQuery query, CancellationToken cancellationToken)
	{
		var keyword = query.Keyword;
		var results = _productRepository.GetProductsByDescriptionKeyword(keyword);

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}