using MimyMart.Windows.Forms;
using System.Runtime.Versioning;
using MimyMart.Windows.Forms.Interfaces;
using MimyMart.Windows.Forms.UI;
using MimyMart.Windows.Forms.UI.Inventory;
using MimyMart.Windows.Forms.UI.Login;
using MimyMart.Windows.Forms.UI.Payment;
using MimyMart.Windows.Forms.UI.Report;
using MimyMart.Windows.Forms.UI.Sale;
using MimyMart.Windows.Forms.UI.Setting;
using MimyMart.Windows.Forms.UI.User;

// ReSharper disable CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

[type: SupportedOSPlatform("windows")]
internal static class ConfigureServices
{
	internal static IServiceCollection AddUIServices(this IServiceCollection services)
    {
		services.AddSingleton<InvoiceProductsReportPanel>()
				.AddSingleton<SalesHistoryReportPanel>()
				.AddSingleton<SalesReportPanel>()
				.AddSingleton<CashFlowCalculatorPanel>()
				.AddSingleton<AcceptPaymentForm>()
				.AddSingleton<AddInvoiceProductForm>()
				.AddSingleton<AddNewInventoryProductForm>()
				.AddSingleton<AddNewInventoryProductWithCustomBarcodeForm>()
				.AddSingleton<AddNewUserForm>()
				.AddSingleton<InventoryPanel>()
				.AddSingleton<MainForm>()
				.AddSingleton<MessageForm>()
				.AddSingleton<PrintReceiptForm>()
				.AddSingleton<ReportsPanel>()
				.AddSingleton<SaleHistoryByInvoiceIdForm>()
				.AddSingleton<SalePanel>()
				.AddSingleton<SettingsPanel>()
				.AddSingleton<UpdateInventoryProductForm>()
				.AddSingleton<UpdateInvoiceProductForm>()
				.AddSingleton<UserLogInPanel>()
				.AddSingleton<UsersPanel>();

		services.AddSingleton<IMachine, Machine>();

		return services;
    }
}