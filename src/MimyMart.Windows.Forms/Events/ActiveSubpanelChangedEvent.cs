using MimyMart.Windows.Forms.Enums;
using Prism.Events;

namespace MimyMart.Windows.Forms.Events;

/// <summary>
/// Event for notifying the active sub-panel has changed on the Main form.
/// </summary>
public class ActiveSubPanelChangedEvent : PubSubEvent<SubPanel>
{
}