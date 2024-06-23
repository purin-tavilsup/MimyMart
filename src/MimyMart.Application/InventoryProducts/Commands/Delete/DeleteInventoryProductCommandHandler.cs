using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;
using MimyMart.Domain.Events;
using Prism.Events;

namespace MimyMart.Application.InventoryProducts.Commands.Delete;

public class DeleteInventoryProductCommandHandler : ICommandHandler<DeleteInventoryProductCommand>
{
	private readonly IInventoryProductRepository _productRepository;
	private readonly IEventAggregator _eventAggregator;

	public DeleteInventoryProductCommandHandler(IInventoryProductRepository productRepository,
												IEventAggregator eventAggregator)
	{
		_productRepository = productRepository;
		_eventAggregator = eventAggregator;
	}

	public Task Handle(DeleteInventoryProductCommand command, CancellationToken cancellationToken)
	{
		_productRepository.RemoveById(command.Id);

		_eventAggregator.GetEvent<InventoryProductDeletedEvent>().Publish();

		return Task.CompletedTask;
	}
}