using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.PayLaterPayments.Commands.DeletePayLaterPayment;

public record DeletePayLaterPaymentCommand(int Id) : ICommand;