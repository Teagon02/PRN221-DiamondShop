﻿using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.IRepositories
{
    public interface IProductRepository
    {
        IList<Product> GetAll();
        PagedResult<Product> GetProductsByCategory(int categoryId, int pageIndex, int pageSize);
        Product GetProductById(int? id);
        Category GetCategoryById(int? id);
        List<Image> GetImagesByProductId(int? productId);
        Task CreateAsync(Product product);
        Task SaveChangesAsync();
        Task AddImage(Image image);
        PagedResult<Product> GetAll(int page, int pageSize);
        Task<IList<ProductPriceDTO>> Dashboardlist();
    }
}
