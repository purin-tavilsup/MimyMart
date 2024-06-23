using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.UserCredentials.Queries.GetUserCredentialById;

public record GetUserCredentialByIdQuery(int Id) : IQuery<UserCredentialDto>;