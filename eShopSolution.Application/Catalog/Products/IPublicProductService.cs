using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Catalog.Products.Manage;
using eShopSolution.ViewModels.Common;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCaregoryId(GetPublicProductPagingRequest request);
    }
}
