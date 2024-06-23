using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InvoiceProducts.Queries.GetInvoiceProductsByInvoiceId;

public record GetInvoiceProductsByInvoiceIdQuery(int InvoiceId) : IQuery<IEnumerable<InvoiceProductDto>>;