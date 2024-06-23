using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.Users.Commands.UpdateUser;

public record UpdateUserCommand : ICommand
{
	public int UserId { get; set; }
        
	public string FirstName { get; set; } = string.Empty;

	public string LastName { get; set; } = string.Empty;
}