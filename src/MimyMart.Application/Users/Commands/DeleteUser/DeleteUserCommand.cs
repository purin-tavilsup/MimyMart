using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.Users.Commands.DeleteUser;

public record DeleteUserCommand(int Id) : ICommand;