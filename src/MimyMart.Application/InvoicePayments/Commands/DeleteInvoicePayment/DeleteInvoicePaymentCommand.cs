using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InvoicePayments.Commands.DeleteInvoicePayment;

public record DeleteInvoicePaymentCommand(int Id) : ICommand;