using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InventoryProducts.Queries.GetByDescriptionKeyword;

public record GetInventoryProductsByDescriptionKeywordQuery(string Keyword) : IQuery<IEnumerable<InventoryProductDto>>;