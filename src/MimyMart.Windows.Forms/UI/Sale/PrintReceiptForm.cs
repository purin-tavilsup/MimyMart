﻿using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using MimyMart.Application.Common.Interfaces;

namespace MimyMart.Windows.Forms.UI.Sale;

[ExcludeFromCodeCoverage]
public partial class PrintReceiptForm : Form
{
	private readonly IReceiptPrinterService _receiptPrinterService;
	private IInvoiceInfo? _invoiceInfo;

	public PrintReceiptForm(IReceiptPrinterService receiptPrinterService)
	{
		_receiptPrinterService = receiptPrinterService;

		InitializeComponent();
	}

	public void ShowDialog(IInvoiceInfo invoiceInfo)
	{
		_invoiceInfo = invoiceInfo;

		ShowDialog();
	}

	private void PrintReceiptButton_Click(object sender, EventArgs e)
	{
		try
		{
			if (_invoiceInfo is null) { return; }

			PrintReceipt(_invoiceInfo);
			
			Hide();
		}
		catch (Exception ex)
		{
			var messageForm = new MessageForm();
			messageForm.ShowDialog($"Error: {ex.Message}", "Unable To Print Receipt!");
		}
	}

	[Conditional("RELEASE")]
	private void PrintReceipt(IInvoiceInfo invoiceInfo)
	{
		_receiptPrinterService.PrintReceipt(invoiceInfo);
	}

	private void CloseFormButton_Click(object sender, EventArgs e)
	{
		Hide();
	}
}