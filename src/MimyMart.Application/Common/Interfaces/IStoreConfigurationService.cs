using MimyMart.Application.Common.Models;

namespace MimyMart.Application.Common.Interfaces;

public interface IStoreConfigurationService
{
	Task<StoreConfiguration> GetAsync();

	StoreConfiguration Get();

	Task UpdateAsync(StoreConfiguration configuration);
}