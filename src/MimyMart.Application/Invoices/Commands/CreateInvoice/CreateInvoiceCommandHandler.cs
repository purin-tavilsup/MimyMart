﻿using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Common.Interfaces;

namespace MimyMart.Application.Invoices.Commands.CreateInvoice;

public class CreateInvoiceCommandHandler : ICommandHandler<CreateInvoiceCommand, int>
{
    private readonly IInvoiceRepository _invoiceRepository;

    public CreateInvoiceCommandHandler(IInvoiceRepository invoiceRepository)
    {
        _invoiceRepository = invoiceRepository;
    }

    public Task<int> Handle(CreateInvoiceCommand command, CancellationToken cancellationToken)
    {
		var id = _invoiceRepository.Add(command.ToEntity());

        return Task.FromResult(id);
    }
}