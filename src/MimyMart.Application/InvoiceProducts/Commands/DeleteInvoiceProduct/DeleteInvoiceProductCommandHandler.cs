using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.InvoiceProducts.Commands.DeleteInvoiceProduct;

public class DeleteInvoiceProductCommandHandler : ICommandHandler<DeleteInvoiceProductCommand>
{
	private readonly IInvoiceProductRepository _invoiceProductRepository;

	public DeleteInvoiceProductCommandHandler(IInvoiceProductRepository invoiceProductRepository)
	{
		_invoiceProductRepository = invoiceProductRepository;
	}

	public Task Handle(DeleteInvoiceProductCommand command, CancellationToken cancellationToken)
	{
		_invoiceProductRepository.RemoveById(command.Id);

		return Task.CompletedTask;
	}
}