using Prism.Events;

namespace MimyMart.Domain.Events;

/// <summary>
/// Event for notifying a payment has been added to sale invoice.
/// </summary>
public class InvoicePaymentAddedEvent : PubSubEvent
{
}