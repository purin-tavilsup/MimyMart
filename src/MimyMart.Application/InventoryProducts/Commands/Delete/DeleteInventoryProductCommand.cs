using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InventoryProducts.Commands.Delete;

public record DeleteInventoryProductCommand(int Id) : ICommand;