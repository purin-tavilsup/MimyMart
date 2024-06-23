using MimyMart.Domain.Entities;

namespace MimyMart.Application.Abstractions.Pos.Repositories;

public interface IStoreConstantRepository
{
	IEnumerable<UserRole> GetUserRoles();

	IEnumerable<PaymentType> GetPaymentTypes();

	IEnumerable<ProductCategory> GetProductCategories();
}