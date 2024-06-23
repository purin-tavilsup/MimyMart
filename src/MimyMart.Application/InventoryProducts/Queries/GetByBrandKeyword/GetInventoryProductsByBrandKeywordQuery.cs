using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InventoryProducts.Queries.GetByBrandKeyword;

public record GetInventoryProductsByBrandKeywordQuery(string Keyword) : IQuery<IEnumerable<InventoryProductDto>>;