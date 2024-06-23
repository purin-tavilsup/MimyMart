using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.Users.Queries.GetUserById;

public record GetUserByIdQuery(int Id) : IQuery<UserDto>;