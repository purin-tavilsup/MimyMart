using MimyMart.Application.Common.Enums;
using MimyMart.Application.Common.Models;

namespace MimyMart.Application.Common.Extensions;

public static class PaymentsExtensions
{
	public static bool HasPayLayerPayment(this IEnumerable<Payment> payments)
	{
		return payments.Any(x => x.PaymentTypeId == (int)PaymentType.PayLater);
	}
}