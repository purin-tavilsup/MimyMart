using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;
using MimyMart.Domain.Events;
using Prism.Events;

namespace MimyMart.Application.InventoryProducts.Commands.Create;

public class CreateInventoryProductCommandHandler : ICommandHandler<CreateInventoryProductCommand>
{
	private readonly IInventoryProductRepository _productRepository;
	private readonly IEventAggregator _eventAggregator;

	public CreateInventoryProductCommandHandler(IInventoryProductRepository productRepository,
												IEventAggregator eventAggregator)
	{
		_productRepository = productRepository;
		_eventAggregator = eventAggregator;
	}

    public Task Handle(CreateInventoryProductCommand command, CancellationToken cancellationToken)
    {
		var id = _productRepository.Add(command.ToEntity());

		_eventAggregator.GetEvent<InventoryProductAddedEvent>().Publish(id);

		return Task.CompletedTask;
	}
}