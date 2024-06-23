using FluentValidation;

namespace MimyMart.Application.InvoiceProducts.Commands.DeleteInvoiceProduct;

public class DeleteInvoiceProductCommandValidator : AbstractValidator<DeleteInvoiceProductCommand>
{
	public DeleteInvoiceProductCommandValidator()
	{
		RuleFor(x => x.Id)
			.GreaterThan(0).WithMessage("Invoice Product ID is invalid.");
	}
}