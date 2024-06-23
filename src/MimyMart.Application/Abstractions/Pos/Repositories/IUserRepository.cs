﻿using MimyMart.Domain.Entities;

namespace MimyMart.Application.Abstractions.Pos.Repositories;

public interface IUserRepository
{
	int Add(UserAccount user);

	bool Update(UserAccount user);

	UserAccount GetById(int id);

	IEnumerable<UserAccount> GetAll();

	bool RemoveById(int id);
}