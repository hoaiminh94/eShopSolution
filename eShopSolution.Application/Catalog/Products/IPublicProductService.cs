﻿using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCaregoryId(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll();

    }
}
