using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.PayLaterPayments.Commands.CreatePayLaterPayment;

public record CreatePayLaterPaymentCommand : ICommand
{
	public int PaymentId { get; set; }

	public string Description { get; set; } = string.Empty;

	public int InvoiceId { get; set; }

	public decimal ReceivableAmount { get; set; }
}