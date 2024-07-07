using Diamond.DataAccess.Data;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.IRepositories;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        DiamondDbContext _dbContext;
        public ProductRepository(DiamondDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddImage(Image image)
        {
            _dbContext.Images.Add(image);
        }

        public async Task CreateAsync(Product product)
        {
            _dbContext.Products.Add(product);
        }

        public async Task<IList<ProductPriceDTO>> Dashboardlist()
        {
            return  _dbContext.Products.Select(p => new ProductPriceDTO
            {
                Name = p.Name,
                Price = p.Price,
            }).ToList();

        }

        public IList<Product> GetAll()
        {
            return _dbContext.Products.Include(p => p.Category)
                   .Include(p => p.Images).ToList();
        }

        public PagedResult<Product> GetAll(int page, int pageSize)
        {
            var query = _dbContext.Products.Include(p => p.Category)
                .Include(p => p.Images).AsQueryable();
            var totalItems = query.Count();
            var users = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return new PagedResult<Product>
            {
                Items = users,
                TotalItems = totalItems,
                PageNumber = page,
                PageSize = pageSize
            };
        }

        public PagedResult<Product> GetAll_02(int page, int pageSize)
        {
            var query = _dbContext.Products.Where(p => p.Status == true).Include(p => p.Category)
                .Include(p => p.Images).AsQueryable();
            var totalItems = query.Count();
            var users = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return new PagedResult<Product>
            {
                Items = users,
                TotalItems = totalItems,
                PageNumber = page,
                PageSize = pageSize
            };
        }

        public Category GetCategoryById(int? id)
        {
            return _dbContext.Categories.Find(id);
        }

        public List<Image> GetImagesByProductId(int? productId)
        {
            return _dbContext.Images.
                Where(i => i.ProductId == productId).ToList();
        }



        public Product GetProductById(int? id)
        {
            return _dbContext.Products.Find(id);
        }

        public PagedResult<Product> GetProductsByCategory(int categoryId, int pageIndex, int pageSize)
        {
            var query = _dbContext.Products
                                .Where(p => p.CategoryId == categoryId)
                                .Include(p => p.Images);

            var totalItems = query.Count();
            var items = query.Skip((pageIndex - 1) * pageSize)
                             .Take(pageSize)
                             .ToList();

            return new PagedResult<Product>
            {
                Items = items,
                TotalItems = totalItems,
                PageNumber = pageIndex,
                PageSize = pageSize
            };
        }


        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
