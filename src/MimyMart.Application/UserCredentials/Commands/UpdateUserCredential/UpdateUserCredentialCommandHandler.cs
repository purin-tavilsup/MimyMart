﻿using MimyMart.Application.Abstractions.Messaging;
using MimyMart.Application.Abstractions.Pos.Repositories;

namespace MimyMart.Application.UserCredentials.Commands.UpdateUserCredential;

public class UpdateUserCredentialCommandHandler : ICommandHandler<UpdateUserCredentialCommand>
{
	private readonly IUserCredentialRepository _userCredentialRepository;

    public UpdateUserCredentialCommandHandler(IUserCredentialRepository userCredentialRepository)
    {
        _userCredentialRepository = userCredentialRepository;
    }

    public Task Handle(UpdateUserCredentialCommand command, CancellationToken cancellationToken)
	{
		_userCredentialRepository.UpdatePassword(command.ToEntity());

		return Task.CompletedTask;
    }
}