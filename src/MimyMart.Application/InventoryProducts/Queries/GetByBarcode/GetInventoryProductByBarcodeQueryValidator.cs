using FluentValidation;

namespace MimyMart.Application.InventoryProducts.Queries.GetByBarcode;

public class GetInventoryProductByBarcodeQueryValidator : AbstractValidator<GetInventoryProductByBarcodeQuery>
{
	public GetInventoryProductByBarcodeQueryValidator()
	{
		RuleFor(x => x.Barcode)
			.NotEmpty().WithMessage("Barcode is required.");
	}
}