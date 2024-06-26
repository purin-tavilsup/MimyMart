﻿using MediatR;
using MimyMart.Application.Common.Interfaces;
using MimyMart.Application.Events;
using MimyMart.Application.UserCredentials;
using MimyMart.Application.UserCredentials.Queries.GetUserCredentialByUsername;
using MimyMart.Application.Users;
using MimyMart.Application.Users.Queries.GetUserById;
using Prism.Events;

namespace MimyMart.Infrastructure.Services;

public class UserLogInService : IUserLogInService
{
	private readonly IMediator _mediator;
	private readonly IEventAggregator _eventAggregator;

	public UserLogInService(IMediator mediator,
							IEventAggregator eventAggregator)
    {
        _mediator = mediator;
        _eventAggregator = eventAggregator;
    }

	public async Task<bool> LogInAsync(string username, string password)
	{
		try
		{
			var userCredential = await GetUserCredentialByUserNameAsync(username);

			if (userCredential.Password != password)
				return false;

			var user = await GetUserByIdAsync(userCredential.UserId);

			_eventAggregator.GetEvent<UserLoggedInEvent>().Publish(new LoggedInUser(user));

			return true;
		}
		catch
		{
			return false;
        }
    }

	public void LogOut()
	{
		_eventAggregator.GetEvent<UserLoggedOutEvent>().Publish();
	}

	private async Task<UserCredentialDto> GetUserCredentialByUserNameAsync(string username)
	{
		return await _mediator.Send(new GetUserCredentialByUsernameQuery(username));
	}

	private async Task<UserDto> GetUserByIdAsync(int id)
	{
		return await _mediator.Send(new GetUserByIdQuery(id));
	}

	private class LoggedInUser : ILoggedInUser
	{
		private readonly UserDto _user;

		public LoggedInUser(UserDto user)
		{
			_user = user;
		}

		public int UserId => _user.UserId;

		public string FirstName => _user.FirstName;

		public string LastName => _user.LastName;

		public int RoleId => _user.RoleId;
	}
}