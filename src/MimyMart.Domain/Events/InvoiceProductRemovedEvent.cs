using Prism.Events;

namespace MimyMart.Domain.Events;

/// <summary>
/// Event for notifying a product has been removed from sale invoice.
/// </summary>
public class InvoiceProductRemovedEvent : PubSubEvent
{
}