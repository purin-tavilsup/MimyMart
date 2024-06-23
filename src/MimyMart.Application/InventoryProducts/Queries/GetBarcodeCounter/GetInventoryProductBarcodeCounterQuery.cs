using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InventoryProducts.Queries.GetBarcodeCounter;

public record GetInventoryProductBarcodeCounterQuery() : IQuery<int>;