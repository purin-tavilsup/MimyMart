using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InventoryProducts.Commands.UpdateInventoryProductBarcodeCounter;

public record UpdateInventoryProductBarcodeCounterCommand(int Counter) : ICommand;