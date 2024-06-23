using MimyMart.Application.Common.Interfaces;
using Prism.Events;

namespace MimyMart.Application.Events;

/// <summary>
/// Event for notifying a user has logged in.
/// </summary>
public class UserLoggedInEvent : PubSubEvent<ILoggedInUser>
{
}