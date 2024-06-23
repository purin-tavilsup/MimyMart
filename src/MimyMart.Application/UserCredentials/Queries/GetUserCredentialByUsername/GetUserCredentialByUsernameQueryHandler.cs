using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.UserCredentials.Queries.GetUserCredentialByUsername;

public class GetUserCredentialByUsernameQueryHandler : IQueryHandler<GetUserCredentialByUsernameQuery, UserCredentialDto>
{
	private readonly IUserCredentialRepository _userCredentialRepository;

	public GetUserCredentialByUsernameQueryHandler(IUserCredentialRepository userCredentialRepository)
	{
		_userCredentialRepository = userCredentialRepository;
	}

	public Task<UserCredentialDto> Handle(GetUserCredentialByUsernameQuery query, CancellationToken cancellationToken)
	{
		var result = _userCredentialRepository.GetByUsername(query.Username);

		return Task.FromResult(result.ToDto());
	}
}