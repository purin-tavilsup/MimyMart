using MimyMart.Application.InvoicePayments.Commands.CreateInvoicePayment;
using MimyMart.Domain.Entities;

namespace MimyMart.Application.InvoicePayments;

internal static class InvoicePaymentExtensions
{
	internal static InvoicePaymentDto ToDto(this Payment entity)
	{
		var dto = new InvoicePaymentDto(entity.PaymentId,
										entity.InvoiceId,
										entity.PaymentTypeId,
										entity.Amount,
										entity.DateCreated,
										entity.Note);
		return dto;
	}

	internal static Payment ToEntity(this CreateInvoicePaymentCommand command)
	{
		var entity = new Payment
		{
			InvoiceId = command.InvoiceId,
			PaymentTypeId = command.PaymentTypeId,
			Amount = command.Amount,
			Note = command.Note
		};

		return entity;
	}
}