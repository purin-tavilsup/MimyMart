using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InventoryProducts.Queries.GetById;

public record GetInventoryProductByIdQuery(int Id) : IQuery<InventoryProductDto>;