using MediatR;

namespace MimyMart.Application.Notifications;

public record SalesCompletedEvent(int InvoiceId) : INotification;