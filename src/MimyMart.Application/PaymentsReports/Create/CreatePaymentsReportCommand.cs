using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.PaymentsReports.Create;

public record CreatePaymentsReportCommand(int InvoiceId) : ICommand;