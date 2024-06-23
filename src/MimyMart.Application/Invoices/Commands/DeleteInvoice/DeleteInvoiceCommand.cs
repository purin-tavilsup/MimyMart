using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.Invoices.Commands.DeleteInvoice;

public record DeleteInvoiceCommand(int Id) : ICommand;