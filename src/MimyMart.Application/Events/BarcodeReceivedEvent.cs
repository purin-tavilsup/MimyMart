﻿using Prism.Events;

namespace MimyMart.Application.Events;

/// <summary>
/// Event for notifying a barcode has been received from a barcode scanner.
/// A barcode will be passed along with the event.
/// </summary>
public class BarcodeReceivedEvent : PubSubEvent<string>
{
}