﻿using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InvoicePayments.Commands.CreateInvoicePayment;

public record CreateInvoicePaymentCommand : ICommand<int>
{
	public int InvoiceId { get; set; }

	public int PaymentTypeId { get; set; }

	public decimal Amount { get; set; }

	public string Note { get; set; } = string.Empty;
}