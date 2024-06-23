using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InventoryProducts.Commands.UpdateQuantity;

public class UpdateInventoryProductQuantityCommand : ICommand
{
	public int Id { get; set; }

	public int Quantity { get; set; }
}