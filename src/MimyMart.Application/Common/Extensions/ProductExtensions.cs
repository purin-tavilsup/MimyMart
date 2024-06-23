using MimyMart.Application.Common.Models;

namespace MimyMart.Application.Common.Extensions;

public static class ProductExtensions
{
    public static bool HasGroupPrice(this Product product)
    {
        if (product.GroupPriceQuantity is null)
        {
            return false;
        }

        return product.GroupPriceQuantity >= 1;
    }
}