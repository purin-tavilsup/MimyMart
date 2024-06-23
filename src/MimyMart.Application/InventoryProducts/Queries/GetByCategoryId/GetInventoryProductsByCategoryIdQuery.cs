using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InventoryProducts.Queries.GetByCategoryId;

public record GetInventoryProductsByCategoryIdQuery(int CategoryId) : IQuery<IEnumerable<InventoryProductDto>>;