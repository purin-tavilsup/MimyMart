using System.Data;

namespace MimyMart.Application.Abstractions.Pos.Repositories;

public interface IDbConnectionProvider
{
	IDbConnection GetDbConnection();

	void BackupDatabase(string backupDatabaseDirectory);
}