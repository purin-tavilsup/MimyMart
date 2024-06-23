using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;
using MimyMart.Domain.Events;
using Prism.Events;

namespace MimyMart.Application.InvoiceProducts.Commands.CreateInvoiceProduct;

public class CreateInvoiceProductCommandHandler : ICommandHandler<CreateInvoiceProductCommand>
{
    private readonly IInvoiceProductRepository _invoiceProductRepository;
    private readonly IEventAggregator _eventAggregator;

    public CreateInvoiceProductCommandHandler(IInvoiceProductRepository invoiceProductRepository, IEventAggregator eventAggregator)
    {
        _invoiceProductRepository = invoiceProductRepository;
        _eventAggregator = eventAggregator;
    }

    public Task Handle(CreateInvoiceProductCommand command, CancellationToken cancellationToken)
    {
		_invoiceProductRepository.Add(command.ToEntity());

        _eventAggregator.GetEvent<InvoiceProductAddedEvent>().Publish();

		return Task.CompletedTask;
    }
}