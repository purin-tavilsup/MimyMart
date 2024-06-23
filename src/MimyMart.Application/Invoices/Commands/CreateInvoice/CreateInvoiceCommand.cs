using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.Invoices.Commands.CreateInvoice;

public record CreateInvoiceCommand : ICommand<int>
{
	public decimal Total { get; set; }

	public int? CustomerId { get; set; }

	public int UserId { get; set; }
}