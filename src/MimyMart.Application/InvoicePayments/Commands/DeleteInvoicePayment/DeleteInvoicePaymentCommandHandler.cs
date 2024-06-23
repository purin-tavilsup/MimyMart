using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.InvoicePayments.Commands.DeleteInvoicePayment;

public class DeleteInvoicePaymentCommandHandler  : ICommandHandler<DeleteInvoicePaymentCommand>
{
	private readonly IInvoicePaymentRepository _invoicePaymentRepository;

	public DeleteInvoicePaymentCommandHandler(IInvoicePaymentRepository invoicePaymentRepository)
	{
		_invoicePaymentRepository = invoicePaymentRepository;
	}

	public Task Handle(DeleteInvoicePaymentCommand command, CancellationToken cancellationToken)
	{
		_invoicePaymentRepository.RemoveById(command.Id);

		return Task.CompletedTask;
	}
}