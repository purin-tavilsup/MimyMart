using MimyMart.Application.Abstractions.Messaging;

namespace MimyMart.Application.Users.Queries.GetUsers;

public record GetUsersQuery() : IQuery<IEnumerable<UserDto>>;