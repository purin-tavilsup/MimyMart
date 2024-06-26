﻿using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;
using MimyMart.Domain.Events;
using Prism.Events;

namespace MimyMart.Application.InvoicePayments.Commands.CreateInvoicePayment;

public class CreateInvoicePaymentCommandHandler : ICommandHandler<CreateInvoicePaymentCommand, int>
{
    private readonly IInvoicePaymentRepository _invoicePaymentRepository;
    private readonly IEventAggregator _eventAggregator;

    public CreateInvoicePaymentCommandHandler(IInvoicePaymentRepository invoicePaymentRepository, IEventAggregator eventAggregator)
    {
        _invoicePaymentRepository = invoicePaymentRepository;
        _eventAggregator = eventAggregator;
    }

    public Task<int> Handle(CreateInvoicePaymentCommand command, CancellationToken cancellationToken)
	{
		var id = _invoicePaymentRepository.Add(command.ToEntity());

		_eventAggregator.GetEvent<InvoicePaymentAddedEvent>().Publish();

        return Task.FromResult(id);
    }
}