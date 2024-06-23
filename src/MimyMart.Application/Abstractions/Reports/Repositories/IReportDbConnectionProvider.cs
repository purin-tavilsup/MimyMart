using System.Data;

namespace MimyMart.Application.Abstractions.Reports.Repositories;

public interface IReportDbConnectionProvider
{
	IDbConnection CreateConnection();
}