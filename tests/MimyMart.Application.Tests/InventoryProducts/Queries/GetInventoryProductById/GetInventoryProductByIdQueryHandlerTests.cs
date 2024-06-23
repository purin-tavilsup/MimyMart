using AutoFixture.Xunit2;
using FluentAssertions;
using MimyMart.Application.Abstractions.Pos.Repositories;
using MimyMart.Application.InventoryProducts;
using MimyMart.Application.InventoryProducts.Queries.GetById;
using MimyMart.Application.Tests.Mocks.Attributes;
using MimyMart.Domain.Entities;
using Moq;
using Xunit;

namespace MimyMart.Application.Tests.InventoryProducts.Queries.GetInventoryProductById;

public class GetInventoryProductByIdQueryHandlerTests
{
	[Theory]
	[CustomAutoData]
	public async Task Handler_ShouldReturnInventoryProduct(
		[Frozen] Mock<IInventoryProductRepository> productRepository,
		GetInventoryProductByIdQueryHandler sut,
		int id,
		InventoryProduct product)
	{
		// Arrange
		productRepository.Setup(x => x.GetById(id))
						 .Returns(product);

		var query = new GetInventoryProductByIdQuery(id);

		// Act
		var result = await sut.Handle(query, default);

		// Assert
		result.Should().BeOfType<InventoryProductDto>()
			  .Which.InventoryProductId.Should().Be(product.InventoryProductId);
	}
}