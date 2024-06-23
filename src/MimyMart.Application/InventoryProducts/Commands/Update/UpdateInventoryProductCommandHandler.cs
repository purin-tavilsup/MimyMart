using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;
using MimyMart.Domain.Events;
using Prism.Events;

namespace MimyMart.Application.InventoryProducts.Commands.Update;

public class UpdateInventoryProductCommandHandler : ICommandHandler<UpdateInventoryProductCommand>
{
	private readonly IInventoryProductRepository _productRepository;
	private readonly IEventAggregator _eventAggregator;

	public UpdateInventoryProductCommandHandler(IInventoryProductRepository productRepository,
												IEventAggregator eventAggregator)
	{
		_productRepository = productRepository;
		_eventAggregator = eventAggregator;
	}

	public Task Handle(UpdateInventoryProductCommand command, CancellationToken cancellationToken)
	{
		_ = _productRepository.Update(command.ToEntity());

		_eventAggregator.GetEvent<InventoryProductUpdatedEvent>().Publish(command.Id);

		return Task.CompletedTask;
	}
}