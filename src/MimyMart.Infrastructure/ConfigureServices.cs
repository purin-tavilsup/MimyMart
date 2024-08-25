using MimyMart.Application.Common.Interfaces;
using LazyCache;
using Prism.Events;
using System.Runtime.Versioning;
using MimyMart.Application.Abstractions.Pos.Repositories;
using MimyMart.Application.Abstractions.Reports.Repositories;
using MimyMart.Infrastructure.Constants;
using MimyMart.Infrastructure.Persistence.Repositories.PostgreSql;
using MimyMart.Infrastructure.Persistence.Repositories.SQLite;
using MimyMart.Infrastructure.Services;

// ReSharper disable CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

[type: SupportedOSPlatform("windows")]
public static class ConfigureServices
{
	public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
	{
		// Persistence
		services.AddSingleton<IReportDbConnectionProvider, ReportDbConnectionProvider>();
		services.AddScoped<IReportRepository, ReportRepository>();

		services.AddSingleton<IDbConnectionProvider, DbConnectionProvider>()
				.AddSingleton<IInvoiceRepository, InvoiceRepository>()
				.AddSingleton<IInvoiceProductRepository, InvoiceProductRepository>()
				.AddSingleton<IInvoicePaymentRepository, InvoicePaymentRepository>()
				.AddSingleton<IInventoryProductRepository, InventoryProductRepository>()
				.AddSingleton<IStoreConstantRepository, StoreConstantRepository>()
				.AddSingleton<IUserRepository, UserRepository>()
				.AddSingleton<IUserCredentialRepository, UserCredentialRepository>();

        services.AddSingleton<IStoreConstants, StoreConstants>()
				.AddSingleton<IStoreConfigurationService, StoreConfigurationService>()
				.AddSingleton<IUserLogInService, UserLogInService>()
				.AddSingleton<ISaleService, SaleService>()
				.AddSingleton<IReportService, ReportService>()
				.AddSingleton<IEventAggregator, EventAggregator>()
				.AddSingleton<IRawInputDeviceService, RawInputDeviceService>()
				.AddSingleton<IReceiptPrinterService, ReceiptPrinterService>()
				.AddSingleton<IAppCache, CachingService>()
				.AddSingleton<HttpClient, HttpClient>();

		services.AddTransient<ICryptographyService, CryptographyService>()
				.AddTransient<IJsonService, JsonService>()
				.AddTransient<IBarcodeGeneratorService, BarcodeGeneratorService>()
				.AddTransient<IDateTimeService, DateTimeService>()
				.AddTransient<ICsvService, CsvService>();

		return services;
    }
}