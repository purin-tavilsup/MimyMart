using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.InvoiceProducts.Queries.GetInvoiceProductsByDateRange;

public record GetInvoiceProductsByDateRangeQuery(DateOnly StartDate, DateOnly EndDate) : IQuery<IEnumerable<InvoiceProductDto>>;