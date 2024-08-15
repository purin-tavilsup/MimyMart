using MimyMart.Application.Common.Models;

namespace MimyMart.Application.Common.Extensions;

public static class PaymentsSummaryExtensions
{
	public static PaymentsReport ToReport(this PaymentsSummary summary, Guid id, DateTime created, int referenceId)
	{
		return new PaymentsReport
		{
			Id = id,
			Created = created,
			ReferenceId = referenceId,
			CashTotal = summary.CashTotal,
			MoneyTransferTotal = summary.MoneyTransferTotal
		};
	}
}