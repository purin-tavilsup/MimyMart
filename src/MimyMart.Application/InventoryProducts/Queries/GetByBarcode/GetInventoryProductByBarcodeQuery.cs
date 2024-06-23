using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InventoryProducts.Queries.GetByBarcode;

public record GetInventoryProductByBarcodeQuery(string Barcode) : IQuery<InventoryProductDto>;