﻿using System.Diagnostics.CodeAnalysis;
using MimyMart.Application.Common.Enums;
using MimyMart.Application.Common.Extensions;
using MimyMart.Application.Common.Interfaces;
using MimyMart.Application.Common.Models;

namespace MimyMart.Windows.Forms.UI.Report;

public partial class SalesReportPanel : UserControl
{
    private readonly IReportService _reportService;

    [ExcludeFromCodeCoverage]
    public SalesReportPanel(IReportService reportService)
    {
        _reportService = reportService;

        InitializeComponent();
    }

    private void ShowSummary(SalesSummary salesSummary, PaymentsSummary paymentsSummary)
	{
		var invoiceTotal = salesSummary.InvoiceTotal;
		var moneyTransferTotal = paymentsSummary.MoneyTransferTotal;
		var cashTotal = invoiceTotal - moneyTransferTotal;

        OverallSaleLabel.Text = $"{invoiceTotal:N2}";
		PaymentByCashLabel.Text = $"{cashTotal:N2}";
        PaymentByTransferLabel.Text = $"{moneyTransferTotal:N2}";
    }

    private async Task<SalesSummary> GetSalesReportByPeriodAsync(TimePeriod period)
    {
        return await _reportService.CreateSalesSummaryByPeriodAsync(period);
    }

	private async Task<SalesSummary> GetSalesReportByDateRangeAsync(DateOnly startDate, DateOnly endDate)
	{
		return await _reportService.CreateSalesSummaryByDateRangeAsync(startDate, endDate);
	}

    private async Task<PaymentsSummary> GetPaymentsReportByPeriodAsync(TimePeriod period)
    {
        return await _reportService.CreatePaymentsSummaryByPeriodAsync(period);
    }

	private async Task<PaymentsSummary> GetPaymentsReportByDateRangeAsync(DateOnly startDate, DateOnly endDate)
	{
		return await _reportService.CreatePaymentsSummaryByDateRangeAsync(startDate, endDate);
	}

    private async void ShowReportByTodayButton_Click(object sender, EventArgs e)
    {
        PeriodLabel.Text = ShowReportByTodayButton.Text;

        var salesReport = await GetSalesReportByPeriodAsync(TimePeriod.Today);
        var paymentsReport = await GetPaymentsReportByPeriodAsync(TimePeriod.Today);

        ShowSummary(salesReport, paymentsReport);
    }

    private async void ShowReportByThisMonthButton_Click(object sender, EventArgs e)
    {
        PeriodLabel.Text = ShowReportByThisMonthButton.Text;

        var salesReport = await GetSalesReportByPeriodAsync(TimePeriod.ThisMonth);
        var paymentsReport = await GetPaymentsReportByPeriodAsync(TimePeriod.ThisMonth);

        ShowSummary(salesReport, paymentsReport);
    }

    private async void ShowReportByThisYearButton_Click(object sender, EventArgs e)
    {
        PeriodLabel.Text = ShowReportByThisYearButton.Text;

        var salesReport = await GetSalesReportByPeriodAsync(TimePeriod.ThisYear);
        var paymentsReport = await GetPaymentsReportByPeriodAsync(TimePeriod.ThisYear);

        ShowSummary(salesReport, paymentsReport);
    }

    private async void ShowReportByDateRangeButton_Click(object sender, EventArgs e)
    {
		var startDate = StartDatePicker.Value.ToDateOnly();
		var endDate = EndDatePicker.Value.ToDateOnly();

		PeriodLabel.Text = $"{startDate:yyyy MMMM dd} - {endDate:yyyy MMMM dd}";

		var salesReport = await GetSalesReportByDateRangeAsync(startDate, endDate);
		var paymentsReport = await GetPaymentsReportByDateRangeAsync(startDate, endDate);

        ShowSummary(salesReport, paymentsReport);
	}
}