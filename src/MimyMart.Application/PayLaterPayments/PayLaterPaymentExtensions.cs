﻿using MimyMart.Application.PayLaterPayments.Commands.CreatePayLaterPayment;
using MimyMart.Application.PayLaterPayments.Commands.UpdatePayLaterPayment;
using MimyMart.Domain.Entities;

namespace MimyMart.Application.PayLaterPayments;

internal static class PayLaterPaymentExtensions
{
	internal static PayLaterPaymentDto ToDto(this PayLaterPayment entity)
	{
		var dto = new PayLaterPaymentDto(entity.PaymentId,
										 entity.Description,
										 entity.InvoiceId,
										 entity.PayLaterAmount,
										 entity.PaidAmount,
										 entity.IsCompleted,
										 entity.DateCreated,
										 entity.DateUpdated);
		return dto;
	}

	internal static PayLaterPayment ToEntity(this CreatePayLaterPaymentCommand command)
	{
		var entity = new PayLaterPayment
		{
			PaymentId = command.PaymentId,
			Description = command.Description,
			InvoiceId = command.InvoiceId,
			PayLaterAmount = command.ReceivableAmount
		};

		return entity;
	}

	internal static PayLaterPayment ToEntity(this UpdatePayLaterPaymentCommand command)
	{
		var entity = new PayLaterPayment
		{
			PaymentId = command.PaymentId,
			PaidAmount = command.PaidAmount,
			IsCompleted = command.IsCompleted
		};

		return entity;
	}
}