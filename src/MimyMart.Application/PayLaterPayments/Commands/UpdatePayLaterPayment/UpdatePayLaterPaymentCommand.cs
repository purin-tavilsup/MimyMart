using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.PayLaterPayments.Commands.UpdatePayLaterPayment;

public record UpdatePayLaterPaymentCommand : ICommand
{
	public int PaymentId { get; set; }

	public decimal PaidAmount { get; set; }

	public bool IsCompleted { get; set; }
}