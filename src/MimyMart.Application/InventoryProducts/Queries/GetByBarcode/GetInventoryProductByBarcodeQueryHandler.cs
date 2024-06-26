﻿using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.InventoryProducts.Queries.GetByBarcode;

public class GetInventoryProductByBarcodeQueryHandler : IQueryHandler<GetInventoryProductByBarcodeQuery, InventoryProductDto>
{
	private readonly IInventoryProductRepository _productRepository;

	public GetInventoryProductByBarcodeQueryHandler(IInventoryProductRepository productRepository)
	{
		_productRepository = productRepository;
	}

	public Task<InventoryProductDto> Handle(GetInventoryProductByBarcodeQuery query, CancellationToken cancellationToken)
	{
		var barcode = query.Barcode;
		var result = _productRepository.GetByBarcode(barcode);

		return Task.FromResult(result.ToDto());
	}
}