using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.UserCredentials.Commands.CreateUserCredential;

public class CreateUserCredentialCommandHandler : ICommandHandler<CreateUserCredentialCommand>
{
	private readonly IUserCredentialRepository _userCredentialRepository;

	public CreateUserCredentialCommandHandler(IUserCredentialRepository userCredentialRepository)
	{
		_userCredentialRepository = userCredentialRepository;
	}

	public Task Handle(CreateUserCredentialCommand command, CancellationToken cancellationToken)
	{
		_userCredentialRepository.Add(command.ToEntity());

		return Task.CompletedTask;
	}
}