using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.UserCredentials.Commands.DeleteUserCredential;

public record DeleteUserCredentialCommand(int Id) : ICommand;