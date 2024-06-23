using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.InventoryProducts.Commands.UpdateInventoryProductBarcodeCounter;

public class UpdateInventoryProductBarcodeCounterCommandHandler : ICommandHandler<UpdateInventoryProductBarcodeCounterCommand>
{
	private readonly IInventoryProductRepository _productRepository;

	public UpdateInventoryProductBarcodeCounterCommandHandler(IInventoryProductRepository productRepository)
	{
		_productRepository = productRepository;
	}

	public Task Handle(UpdateInventoryProductBarcodeCounterCommand command, CancellationToken cancellationToken)
	{
		_ = _productRepository.UpdateProductBarcodeCounter(command.Counter);

		return Task.CompletedTask;
	}
}