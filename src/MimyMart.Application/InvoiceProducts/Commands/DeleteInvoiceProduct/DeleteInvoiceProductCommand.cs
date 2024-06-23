using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InvoiceProducts.Commands.DeleteInvoiceProduct;

public record DeleteInvoiceProductCommand(int Id) : ICommand;