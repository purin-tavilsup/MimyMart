using MimyMart.Application.Common.Models;

namespace MimyMart.Application.Common.Extensions;

public static class SalesSummaryExtensions
{
	public static SalesReport ToReport(this SalesSummary summary, Guid id, DateTime created, int referenceId)
	{
		return new SalesReport
		{
			Id = id,
			Created = created,
			ReferenceId = referenceId,
			InvoiceTotal = summary.InvoiceTotal
		};
	}
}