using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.InventoryProducts.Queries.GetBarcodeCounter;

public class GetInventoryProductBarcodeCounterQueryHandler : IQueryHandler<GetInventoryProductBarcodeCounterQuery, int>
{
	private readonly IInventoryProductRepository _productRepository;

	public GetInventoryProductBarcodeCounterQueryHandler(IInventoryProductRepository productRepository)
	{
		_productRepository = productRepository;
	}

	public Task<int> Handle(GetInventoryProductBarcodeCounterQuery query, CancellationToken cancellationToken)
	{
		var result = _productRepository.GetProductBarcodeCounter();

		return Task.FromResult(result);
	}
}