﻿using MimyMart.Application.Common.Models;

namespace MimyMart.Application.Common.Interfaces;

public interface IInvoiceInfo
{
	int Id { get; }

	IList<Product> Products { get; }

	IList<Payment> Payments { get; }

	bool IsRefundInvoice { get; }

	decimal InvoiceTotal { get; }

	decimal PaymentTotal { get; }

	decimal Changes { get; }
}