using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.IRepositories;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using Diamond.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.BusinessLogic.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productrepo;
        public ProductService(IProductRepository productRepository)
        {
            _productrepo = productRepository;
        }

        public async Task AddImage(Image image)
        {
           await _productrepo.AddImage(image);    
        }

        public async Task CreateAsync(Product product)
        {
            _productrepo.CreateAsync(product);
        }

        public async Task<IList<ProductPriceDTO>>Dashboardlist()
        {
           return await _productrepo.Dashboardlist();
        }

        public IList<Product> GetAll()
        {
            return _productrepo.GetAll();
        }

        public PagedResult<Product> GetAllpage(int page, int pageSize, string searchTerm)
        {
            var page1 = _productrepo.GetAll(page, pageSize ,searchTerm);
            return page1;
        }

        public PagedResult<Product> GetAll_02(int page, int pageSize, string searchTerm)
        {
            var page2 = _productrepo.GetAll_02(page, pageSize,searchTerm);
            return page2;
        }

        public Category GetCategoryById(int? categoryId)
        {
            return _productrepo.GetCategoryById(categoryId);
        }

        public List<Image> GetImagesByProductId(int? productId)
        {
            return _productrepo.GetImagesByProductId(productId);
        }

      

        public Product GetProductById(int? id)
        {
            return _productrepo.GetProductById(id);
        }

        public PagedResult<Product> GetProductsByCategory(int categoryId, int pageIndex, int pageSize)
        {
            return _productrepo.GetProductsByCategory(categoryId, pageIndex, pageSize);
        }

        public async Task SaveChangesAsync()
        {
            await _productrepo.SaveChangesAsync();
        }

    }
}
