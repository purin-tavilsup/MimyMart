﻿namespace MimyMart.Application.PayLaterPayments;

public record PayLaterPaymentDto(
	int PaymentId,
	string Description,
	int InvoiceId,
	decimal ReceivableAmount,
	decimal PaidAmount,
	bool IsCompleted,
	string DateCreated,
	string DateUpdated);