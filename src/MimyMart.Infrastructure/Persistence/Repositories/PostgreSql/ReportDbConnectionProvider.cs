using System.Data;
using Microsoft.Extensions.Configuration;
using MimyMart.Application.Abstractions.Reports.Repositories;
using Npgsql;

namespace MimyMart.Infrastructure.Persistence.Repositories.PostgreSql;

public class ReportDbConnectionProvider : IReportDbConnectionProvider
{
	private readonly string _connectionString;
	
	public ReportDbConnectionProvider(IConfiguration configuration)
	{
		_connectionString = configuration.GetConnectionString("MimyMartPosDb") ?? string.Empty;
	}

	public IDbConnection CreateConnection()
	{
		return new NpgsqlConnection(_connectionString);
	}
}