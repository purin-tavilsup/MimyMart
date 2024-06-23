using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.SalesReports.Create;

public record CreateSalesReportCommand(int InvoiceId, bool HasPayLaterPayment) : ICommand;