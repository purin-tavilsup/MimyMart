using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimyMart.Application.Abstractions;
using MimyMart.Application.Common.Enums;
using MimyMart.Application.Common.Interfaces;
using MimyMart.Application.Common.Models;
using MimyMart.Application.Enums;

namespace MimyMart.Windows.Forms.UI.Report;

[ExcludeFromCodeCoverage]
public partial class CashFlowCalculatorPanel : UserControl
{
	private readonly IReportService _reportService;
	private readonly IJsonService _jsonService;
	private readonly ICsvService _csvService;
	private readonly ILogger<MainForm> _logger;
    private SalesSummary? _salesSummary;
    private PaymentsSummary? _paymentsSummary;
    private readonly string _dataDirectory;
    private readonly string _csvDirectory;
	private readonly string _backupDirectory;

	private string CsvFilePath => @$"{_csvDirectory}\\CashFlow_{DateTime.Today:yyyy-MMMM-dd}.csv";
    private string DataFilePath => @$"{_dataDirectory}\\CashFlow_{DateTime.Today:yyyy-MMMM-dd}.json";
    private string BackupFilePath => @$"{_backupDirectory}\\CashFlow_{DateTime.Today:yyyy-MMMM-dd}.csv";

    public CashFlowCalculatorPanel(IReportService reportService, 
                                   IJsonService jsonService,
                                   ICsvService csvService,
                                   ILogger<MainForm> logger, 
                                   IConfiguration configuration, 
                                   IInstalledOsLanguage installedOsLanguage)
	{
        _reportService = reportService;
		_jsonService = jsonService;
		_csvService = csvService;
		_logger = logger;

        _dataDirectory = GetDataDirectory(configuration);
        _csvDirectory = GetCsvDirectory(configuration);
        _backupDirectory = GetBackupDirectory(configuration, installedOsLanguage);
        
        InitializeComponent();
		InitializeChangesListView();
		InitializePayOutListView();
		LoadSavedData();

		RemovePayOutButton.Enabled = false;
		RemoveChangeButton.Enabled = false;

		DateLabel.Text = $"Date: {DateTime.Today:D}";
    }
    
    private static string GetBackupDirectory(IConfiguration configuration, IInstalledOsLanguage installedOsLanguage)
    {
        var path = configuration.GetValue<string>("CashFlow:BackupDirectory") ?? @"G:\\My Drive\\MimyMart\\Data\\CSV";

        return installedOsLanguage.Language == OsLanguage.Thai 
                   ? path.Replace("My Drive", "ไดรฟ์ของฉัน") 
                   : path;
    }
    
    private static string GetDataDirectory(IConfiguration configuration)
    {
        var path = configuration.GetValue<string>("CashFlow:DataDirectory");

        return path ?? @"C:\\ProgramData\\MimyMart\\CashFlow\\Data";
    }
    
    private static string GetCsvDirectory(IConfiguration configuration)
    {
        var path = configuration.GetValue<string>("CashFlow:CsvDirectory");

        return path ?? @"C:\\ProgramData\\MimyMart\\CashFlow\\CSV";
    }

	private async Task<SalesSummary> GetSalesReportAsync()
    {
        return await _reportService.CreateSalesSummaryByPeriodAsync(TimePeriod.Today);
    }

    private async Task<PaymentsSummary> GetPaymentsReportAsync()
    {
        return await _reportService.CreatePaymentsSummaryByPeriodAsync(TimePeriod.Today);
    }

    private void InitializeChangesListView()
    {
        ChangesListView.View = View.Details;
        ChangesListView.GridLines = false;
        ChangesListView.FullRowSelect = true;
        
        ChangesListView.Columns.Add("เวลา", 70, HorizontalAlignment.Center);
        ChangesListView.Columns.Add("จำนวน", 130, HorizontalAlignment.Right);

		ChangesListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
    }

    private void InitializePayOutListView()
    {
        PayoutsListView.View = View.Details;
        PayoutsListView.GridLines = false;
        PayoutsListView.FullRowSelect = true;

        PayoutsListView.Columns.Add("เวลา", 70, HorizontalAlignment.Center);
        PayoutsListView.Columns.Add("รายการ", 120, HorizontalAlignment.Center);
        PayoutsListView.Columns.Add("จำนวน", 100, HorizontalAlignment.Right);

		PayoutsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
	}

    private void LoadSavedData()
    {
		if (!Directory.Exists(_dataDirectory))
		{
			Directory.CreateDirectory(_dataDirectory);
		}

		if (!Directory.Exists(_csvDirectory))
		{
			Directory.CreateDirectory(_csvDirectory);
		}

        var data = LoadDataFromFile();

		SalesTotalLabel.Text = $"{data.SalesTotal:N2}";
        MoneyTransferPaymentTotalLabel.Text = $"{data.MoneyTransferTotal:N2}";

        AddChangesToListView(data.Changes);
        AddPayoutsToListView(data.Payouts);

        ChangesTotalLabel.Text = $"{data.ChangesTotal:N2}";
        PayoutsTotalLabel.Text = $"{data.PayoutsTotal:N2}";

        DisplayBankNote1000Total(data);
        DisplayBankNote500Total(data);
        DisplayBankNote100Total(data);
        DisplayBankNote50Total(data);
        DisplayBankNote20Total(data);

        DisplayCoin10Total(data);
        DisplayCoin5Total(data);
        DisplayCoin2Total(data);
        DisplayCoin1Total(data);
    }

    private CashFlowData LoadDataFromFile()
    {
        return File.Exists(DataFilePath) ? _jsonService.ReadFromFile<CashFlowData>(DataFilePath) : new CashFlowData();
    }

    private async Task SaveDataToJsonFileAsync(CashFlowData data)
    {
        try
        {
            await _jsonService.SaveToFileAsync(data, DataFilePath);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "บันทึกไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			var message = $"Failed to save data file [{DataFilePath}] to directory [{_dataDirectory}]";

            _logger.LogWarning(ex, "{Message}", message);
        }
    }

	private async Task SaveDataToCsvFileAsync(CashFlowData data)
	{
		try
		{
			var records = new List<CashFlowData> { data };

			await _csvService.WriteToCsvFile(records, CsvFilePath);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "บันทึกไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			var message = $"Failed to save csv file [{CsvFilePath}] to directory [{_csvDirectory}]";

            _logger.LogWarning(ex, "{Message}", message);
		}
	}

    private void CopyCsvFileToSharedDirectory()
    {
		try
		{
            File.Copy(CsvFilePath, BackupFilePath, overwrite: true);
		}
		catch (Exception ex)
		{
            var message = $"Failed to copy file [{CsvFilePath}] to directory [{_backupDirectory}]";

            _logger.LogWarning(ex, "{Message}", message);
		}
    }

    private CashFlowData CreateCashFlowData()
    {
		var now = DateTime.Now;
        var data = new CashFlowData
        {
            Date = $"{now:yyyy MMMM dd}",
			Time = $"{now:h:mm:ss tt}",
            SalesTotal = _salesSummary?.InvoiceTotal ?? 0m,
            MoneyTransferTotal = _paymentsSummary?.MoneyTransferTotal ?? 0m,

            Changes = GetChangesFromListView(),
            Payouts = GetPayoutsFromListView(),

            BankNote1000Count = GetBankNote1000Count(),
            BankNote500Count = GetBankNote500Count(),
            BankNote100Count = GetBankNote100Count(),
            BankNote50Count = GetBankNote50Count(),
            BankNote20Count = GetBankNote20Count(),

            Coin10Count = GetCoin10Count(),
            Coin5Count = GetCoin5Count(),
            Coin2Count = GetCoin2Count(),
            Coin1Count = GetCoin1Count()
        };

        return data;
    }

    private async void PullLatestDataFromDatabaseButton_Click(object sender, EventArgs e)
    {
		_salesSummary = await GetSalesReportAsync();
		_paymentsSummary = await GetPaymentsReportAsync();

        UpdateResults();
    }

    private void UpdateResults()
    {
        var data = CreateCashFlowData();

        DisplayResults(data);
    }

    private async void SaveToFileButton_Click(object sender, EventArgs e)
    {
		var data = CreateCashFlowData();

        await SaveDataToJsonFileAsync(data);
		await SaveDataToCsvFileAsync(data);

		CopyCsvFileToSharedDirectory();

		MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.None);
	}

    private void DisplayResults(CashFlowData data)
    {
        var expectedCash = CalculateExpectedCash(data);
        var actualCash = CalculateActualCash(data);
        var diffCash = actualCash - expectedCash;

        SalesTotalLabel.Text = $"{data.SalesTotal:N2}";
		MoneyTransferPaymentTotalLabel.Text = $"{data.MoneyTransferTotal:N2}";

        ChangesTotalLabel.Text = $"{data.ChangesTotal:N2}";
        PayoutsTotalLabel.Text = $"{data.PayoutsTotal:N2}";

        DisplayBankNote1000Total(data);
        DisplayBankNote500Total(data);
        DisplayBankNote100Total(data);
        DisplayBankNote50Total(data);
        DisplayBankNote20Total(data);

        DisplayCoin10Total(data);
        DisplayCoin5Total(data);
        DisplayCoin2Total(data);
        DisplayCoin1Total(data);

        CalculatedCashTotalLabel.Text = $"{expectedCash:N2}";
        ActualCashTotalLabel.Text = $"{actualCash:N2}";
        DiffCashLabel.Text = $"{diffCash:N2}";

        if (diffCash == 0)
        {
            DiffCashDescriptionLabel.Text = "พอดี";
        }
        else
        {
            DiffCashDescriptionLabel.Text = diffCash > 0 ? "เกิน" : "ขาด";
        }
    }

    private static decimal CalculateExpectedCash(CashFlowData data)
    {
        var expectedCash = data.SalesTotal
                         + data.ChangesTotal
                         - data.MoneyTransferTotal
                         - data.PayoutsTotal;

        return expectedCash;
    }

    private static decimal CalculateActualCash(CashFlowData data)
    {
		var actualCash = data.BankNote1000Total
					   + data.BankNote500Total
					   + data.BankNote100Total
					   + data.BankNote50Total
					   + data.BankNote20Total
					   + data.Coin10Total
					   + data.Coin5Total
					   + data.Coin2Total
					   + data.Coin1Total;

        return actualCash;
    }

    private IEnumerable<Change> GetChangesFromListView()
    {
        return ChangesListView.Items.Cast<ListViewItem>().Select(x => new Change
        {
            Date = x.SubItems[0].Text,
            Amount = decimal.Parse(x.SubItems[1].Text)
        });
    }

    private void AddChangesToListView(IEnumerable<Change> changes)
    {
        foreach (var change in changes)
        {
            var rowItem = new[] { change.Date, $"{change.Amount:N2}" };
            var item = new ListViewItem(rowItem);

            ChangesListView.Items.Add(item);
        }
    }

    private IEnumerable<Payout> GetPayoutsFromListView()
    {
        return PayoutsListView.Items.Cast<ListViewItem>().Select(x => new Payout
        {
            Date = x.SubItems[0].Text,
            Description = x.SubItems[1].Text,
            Amount = decimal.Parse(x.SubItems[2].Text)
        });
    }

    private void AddPayoutsToListView(IEnumerable<Payout> payouts)
    {
        foreach (var payout in payouts)
        {
            var rowItem = new[] { payout.Date, payout.Description, $"{payout.Amount:N2}" };
            var item = new ListViewItem(rowItem);

            PayoutsListView.Items.Add(item);
        }
    }

	private void AddChangeButton_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(ChangeAmountTextBox.Texts.Trim(), out var amount))
        {
            MessageBox.Show("จำนวนเงินทอนไม่ถูกต้อง", "เพิ่มเงินทอนไม่สำเร็จ");
            return;
        }

        var rowItem = new[] { $"{DateTime.Now:t}", $"{amount:N2}" };
        var item = new ListViewItem(rowItem);

        ChangesListView.Items.Add(item);

        ChangeAmountTextBox.Texts = string.Empty;

        UpdateResults();
    }

    private void AddPayOutItemButton_Click(object sender, EventArgs e)
    {

        if (!decimal.TryParse(PayOutAmountTextBox.Texts.Trim(), out var amount))
        {
            MessageBox.Show("จำนวนรายจ่ายไม่ถูกต้อง", "เพิ่มรายจ่ายไม่สำเร็จ");
            return;
        }

        var itemName = PayOutItemTextBox.Texts.Trim();

        var rowItem = new[] { $"{DateTime.Now:t}", itemName, $"{amount:N2}" };
        var item = new ListViewItem(rowItem);

        PayoutsListView.Items.Add(item);

        PayOutItemTextBox.Texts = string.Empty;
        PayOutAmountTextBox.Texts = string.Empty;

        UpdateResults();
    }

	private void RemoveChangeButton_Click(object sender, EventArgs e)
    {
        try
        {
            var item = ChangesListView.SelectedItems[0];

            ChangesListView.Items.Remove(item);

            RemoveChangeButton.Enabled = false;

            UpdateResults();
        }
        catch
        {
            RemoveChangeButton.Enabled = false;
        }
    }

    private void RemovePayOutItemButton_Click(object sender, EventArgs e)
    {
        try
        {
            var item = PayoutsListView.SelectedItems[0];

            PayoutsListView.Items.Remove(item);

            RemovePayOutButton.Enabled = false;

            UpdateResults();
        }
        catch
        {
            RemovePayOutButton.Enabled = false;
        }
    }

	private void ChangesListView_Click(object sender, EventArgs e)
    {
        var items = ChangesListView.SelectedItems;

        RemoveChangeButton.Enabled = items.Count == 1;
    }

    private void PayOutListView_Click(object sender, EventArgs e)
    {
        var items = PayoutsListView.SelectedItems;

        RemovePayOutButton.Enabled = items.Count == 1;
    }

	private void BankNote1000CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote1000CountTextBox.Texts))
        {
            BankNote1000CountTextBox.Texts = "0";
        }
    }

    private void BankNote500CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote500CountTextBox.Texts))
        {
            BankNote500CountTextBox.Texts = "0";
        }
    }

    private void BankNote100CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote100CountTextBox.Texts))
        {
            BankNote100CountTextBox.Texts = "0";
        }
    }

    private void BankNote50CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote50CountTextBox.Texts))
        {
            BankNote50CountTextBox.Texts = "0";
        }
    }

    private void BankNote20CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote20CountTextBox.Texts))
        {
            BankNote20CountTextBox.Texts = "0";
        }
    }

    private void Coin10CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin10CountTextBox.Texts))
        {
            Coin10CountTextBox.Texts = "0";
        }
    }

    private void Coin5CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin5CountTextBox.Texts))
        {
            Coin5CountTextBox.Texts = "0";
        }
    }

    private void Coin2CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin2CountTextBox.Texts))
        {
            Coin2CountTextBox.Texts = "0";
        }
    }

    private void Coin1CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin1CountTextBox.Texts))
        {
            Coin1CountTextBox.Texts = "0";
        }
    }

    private void DisplayBankNote1000Total(CashFlowData data)
    {
        BankNote1000CountTotalLabel.Text = $"{data.BankNote1000Total:N2}";
        BankNote1000CountTextBox.Texts = data.BankNote1000Count.ToString();
    }

    private void DisplayBankNote500Total(CashFlowData data)
    {
        BankNote500CountTotalLabel.Text = $"{data.BankNote500Total:N2}";
        BankNote500CountTextBox.Texts = data.BankNote500Count.ToString();
    }

    private void DisplayBankNote100Total(CashFlowData data)
    {
        BankNote100CountTotalLabel.Text = $"{data.BankNote100Total:N2}";
        BankNote100CountTextBox.Texts = data.BankNote100Count.ToString();
    }

    private void DisplayBankNote50Total(CashFlowData data)
    {
        BankNote50CountTotalLabel.Text = $"{data.BankNote50Total:N2}";
        BankNote50CountTextBox.Texts = data.BankNote50Count.ToString();
    }

    private void DisplayBankNote20Total(CashFlowData data)
    {
        BankNote20CountTotalLabel.Text = $"{data.BankNote20Total:N2}";
        BankNote20CountTextBox.Texts = data.BankNote20Count.ToString();
    }

    private void DisplayCoin10Total(CashFlowData data)
    {
        Coin10CountTotalLabel.Text = $"{data.Coin10Total:N2}";
        Coin10CountTextBox.Texts = data.Coin10Count.ToString();
    }

    private void DisplayCoin5Total(CashFlowData data)
    {
        Coin5CountTotalLabel.Text = $"{data.Coin5Total:N2}";
        Coin5CountTextBox.Texts = data.Coin5Count.ToString();
    }

    private void DisplayCoin2Total(CashFlowData data)
    {
        Coin2CountTotalLabel.Text = $"{data.Coin2Total:N2}";
        Coin2CountTextBox.Texts = data.Coin2Count.ToString();
    }

    private void DisplayCoin1Total(CashFlowData data)
    {
        Coin1CountTotalLabel.Text = $"{data.Coin1Total:N2}";
        Coin1CountTextBox.Texts = data.Coin1Count.ToString();
    }

    private int GetBankNote1000Count()
    {
        return int.TryParse(BankNote1000CountTextBox.Texts, out var count) ? count : 0;
    }

    private int GetBankNote500Count()
    {
        return int.TryParse(BankNote500CountTextBox.Texts, out var count) ? count : 0;
    }

    private int GetBankNote100Count()
    {
        return int.TryParse(BankNote100CountTextBox.Texts, out var count) ? count : 0;
    }

    private int GetBankNote50Count()
    {
        return int.TryParse(BankNote50CountTextBox.Texts, out var count) ? count : 0;
    }

    private int GetBankNote20Count()
    {
        return int.TryParse(BankNote20CountTextBox.Texts, out var count) ? count : 0;
    }

    private int GetCoin10Count()
    {
        return int.TryParse(Coin10CountTextBox.Texts, out var count) ? count : 0;
    }

    private int GetCoin5Count()
    {
        return int.TryParse(Coin5CountTextBox.Texts, out var count) ? count : 0;
    }

    private int GetCoin2Count()
    {
        return int.TryParse(Coin2CountTextBox.Texts, out var count) ? count : 0;
    }

    private int GetCoin1Count()
    {
        return int.TryParse(Coin1CountTextBox.Texts, out var count) ? count : 0;
    }

    private static bool IsValidCountNumber(string value)
    {
        return !string.IsNullOrWhiteSpace(value) && int.TryParse(value, out _);
    }

    private void BankNote1000CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote1000CountTextBox.Texts)) { return; }

        UpdateResults();
    }

    private void BankNote500CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote500CountTextBox.Texts)) { return; }

        UpdateResults();
    }

    private void BankNote100CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote100CountTextBox.Texts)) { return; }

        UpdateResults();
    }

    private void BankNote50CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote50CountTextBox.Texts)) { return; }

        UpdateResults();
    }

    private void BankNote20CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote20CountTextBox.Texts)) { return; }

        UpdateResults();
    }

    private void Coin10CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin10CountTextBox.Texts)) { return; }

        UpdateResults();
    }

    private void Coin5CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin5CountTextBox.Texts)) { return; }

        UpdateResults();
    }

    private void Coin2CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin2CountTextBox.Texts)) { return; }

        UpdateResults();
    }

    private void Coin1CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin1CountTextBox.Texts)) { return; }

        UpdateResults();
    }

    private void ResetCountingButton_Click(object sender, EventArgs e)
	{
		var data = new CashFlowData();

        DisplayBankNote1000Total(data);
        DisplayBankNote500Total(data);
        DisplayBankNote100Total(data);
        DisplayBankNote50Total(data);
        DisplayBankNote20Total(data);
		DisplayCoin10Total(data);
        DisplayCoin5Total(data);
        DisplayCoin2Total(data);
        DisplayCoin1Total(data);
    }
	
}