using AutoFixture.Xunit2;
using FluentAssertions;
using MimyMart.Application.Abstractions.Pos.Repositories;
using MimyMart.Application.InventoryProducts;
using MimyMart.Application.InventoryProducts.Queries.GetByBarcode;
using MimyMart.Application.Tests.Mocks.Attributes;
using MimyMart.Domain.Entities;
using Moq;
using Xunit;

namespace MimyMart.Application.Tests.InventoryProducts.Queries.GetInventoryProductByBarcode;

public class GetInventoryProductByBarcodeQueryHandlerTests
{
	[Theory]
	[CustomAutoData]
    public async Task Handler_ShouldReturnInventoryProduct(
		[Frozen] Mock<IInventoryProductRepository> productRepository,
		GetInventoryProductByBarcodeQueryHandler sut,
		string barcode,
		InventoryProduct product)
	{
		// Arrange
		productRepository.Setup(x => x.GetByBarcode(barcode))
						 .Returns(product);

		var query = new GetInventoryProductByBarcodeQuery(barcode);

		// Act
		var result = await sut.Handle(query, default);

		// Assert
		result.Should().BeOfType<InventoryProductDto>()
			  .Which.Barcode.Should().Be(product.Barcode);
	}
}