﻿using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.UserCredentials.Commands.DeleteUserCredential;

public class DeleteUserCredentialCommandHandler : ICommandHandler<DeleteUserCredentialCommand>
{
	private readonly IUserCredentialRepository _userCredentialRepository;

	public DeleteUserCredentialCommandHandler(IUserCredentialRepository userCredentialRepository)
	{
		_userCredentialRepository = userCredentialRepository;
	}

	public Task Handle(DeleteUserCredentialCommand command, CancellationToken cancellationToken)
	{
		_userCredentialRepository.RemoveById(command.Id);

		return Task.CompletedTask;
	}
}