using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InvoiceProducts.Queries.GetInvoiceProductsByDate;

public record GetInvoiceProductsByDateQuery(DateOnly Date) : IQuery<IEnumerable<InvoiceProductDto>>;