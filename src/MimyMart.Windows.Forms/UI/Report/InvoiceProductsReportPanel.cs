﻿using System.Diagnostics.CodeAnalysis;
using MimyMart.Application.Common.Extensions;
using MimyMart.Application.Common.Interfaces;
using MimyMart.Application.InvoiceProducts;

namespace MimyMart.Windows.Forms.UI.Report;

[ExcludeFromCodeCoverage]
public partial class InvoiceProductsReportPanel : UserControl
{
	private readonly IReportService _reportService;
	private IEnumerable<InvoiceProductDto> _products;

	private enum ProductColumn
	{
		InvoiceId,
		ProductCode,
		Description,
		Quantity,
		UnitPrice,
		Total,
		DateCreated,
		Note
	}

	public InvoiceProductsReportPanel(IReportService reportService)
	{
		_reportService = reportService;
		_products = Enumerable.Empty<InvoiceProductDto>();

		InitializeComponent();
		InitializeInvoiceProductsDataView();

		StartDatePicker.Value = DateTime.Today;
		EndDatePicker.Value = DateTime.Today;
	}

	private void InitializeInvoiceProductsDataView()
	{
		#region Initialize all columns

		InvoiceProductsDataView.Columns.Clear();
		InvoiceProductsDataView.ColumnCount = 8;

		InvoiceProductsDataView.Columns[(int)ProductColumn.InvoiceId].Name = "Invoice ID";
		InvoiceProductsDataView.Columns[(int)ProductColumn.InvoiceId].Width = 200;
		InvoiceProductsDataView.Columns[(int)ProductColumn.InvoiceId].ReadOnly = true;

		InvoiceProductsDataView.Columns[(int)ProductColumn.ProductCode].Name = "รหัสสินค้า";
		InvoiceProductsDataView.Columns[(int)ProductColumn.ProductCode].Width = 200;
		InvoiceProductsDataView.Columns[(int)ProductColumn.ProductCode].ReadOnly = true;

		InvoiceProductsDataView.Columns[(int)ProductColumn.Description].Name = "คำอธิบาย";
		InvoiceProductsDataView.Columns[(int)ProductColumn.Description].Width = 350;
		InvoiceProductsDataView.Columns[(int)ProductColumn.Description].ReadOnly = true;

		InvoiceProductsDataView.Columns[(int)ProductColumn.Quantity].Name = "จำนวน";
		InvoiceProductsDataView.Columns[(int)ProductColumn.Quantity].Width = 100;
		InvoiceProductsDataView.Columns[(int)ProductColumn.Quantity].ReadOnly = true;

		InvoiceProductsDataView.Columns[(int)ProductColumn.UnitPrice].Name = "ราคาต่อหน่วย";
		InvoiceProductsDataView.Columns[(int)ProductColumn.UnitPrice].Width = 150;
		InvoiceProductsDataView.Columns[(int)ProductColumn.UnitPrice].ReadOnly = true;
		InvoiceProductsDataView.Columns[(int)ProductColumn.UnitPrice].DefaultCellStyle.Format = "N2";

		InvoiceProductsDataView.Columns[(int)ProductColumn.Total].Name = "ราคารวม";
		InvoiceProductsDataView.Columns[(int)ProductColumn.Total].Width = 150;
		InvoiceProductsDataView.Columns[(int)ProductColumn.Total].ReadOnly = true;
		InvoiceProductsDataView.Columns[(int)ProductColumn.Total].DefaultCellStyle.Format = "N2";

		InvoiceProductsDataView.Columns[(int)ProductColumn.DateCreated].Name = "วันและเวลาที่บันทึก";
		InvoiceProductsDataView.Columns[(int)ProductColumn.DateCreated].Width = 200;
		InvoiceProductsDataView.Columns[(int)ProductColumn.DateCreated].ReadOnly = true;

		InvoiceProductsDataView.Columns[(int)ProductColumn.Note].Name = "Note";
		InvoiceProductsDataView.Columns[(int)ProductColumn.Note].Width = 200;
		InvoiceProductsDataView.Columns[(int)ProductColumn.Note].ReadOnly = true;

		#endregion
	}

	private void AddProductToInvoiceDataView(InvoiceProductDto product)
	{
		var columnCount = InvoiceProductsDataView.ColumnCount;
		var productRow = new object[columnCount];
		var total = !product.IsGroupProduct ? product.UnitPrice * product.Quantity : product.GroupPrice;

		productRow[(int) ProductColumn.InvoiceId] = product.InvoiceId;
		productRow[(int) ProductColumn.ProductCode] = product.Barcode;
		productRow[(int) ProductColumn.Description] = product.Description;
		productRow[(int) ProductColumn.Quantity] = product.Quantity;
		productRow[(int) ProductColumn.UnitPrice] = product.UnitPrice;
		productRow[(int) ProductColumn.Total] = total;
		productRow[(int) ProductColumn.DateCreated] = product.DateCreated;
		productRow[(int) ProductColumn.Note] = product.Note;

		var rowIndex = InvoiceProductsDataView.Rows.Add(productRow);
		var rowBackColor = rowIndex % 2 == 0 ? Color.FromArgb(38,38,38) : Color.FromArgb(48, 48, 48);

		InvoiceProductsDataView.Rows[rowIndex].DefaultCellStyle.BackColor = rowBackColor;
	}

	private void ShowInvoiceProducts(IEnumerable<InvoiceProductDto> products)
	{
		InvoiceProductsDataView.Rows.Clear();

		foreach (var product in products)
		{
			AddProductToInvoiceDataView(product);
		}
	}

	private async Task<IEnumerable<InvoiceProductDto>> GetInvoiceProductsAsync()
	{
		var startDate = StartDatePicker.Value.ToDateOnly();
		var endDate = EndDatePicker.Value.ToDateOnly();

		return await _reportService.GetInvoiceProductsByDateRangeAsync(startDate, endDate);
	}

	private async void ShowProductsByDateRangeButton_Click(object sender, EventArgs e)
	{
		_products = await GetInvoiceProductsAsync();

		ShowInvoiceProducts(_products);
	}
}