using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.UserCredentials.Queries.GetUserCredentialByUsername;

public record GetUserCredentialByUsernameQuery(string Username) : IQuery<UserCredentialDto>;