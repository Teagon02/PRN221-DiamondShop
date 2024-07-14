using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.BusinessLogic.IServices
{
    public interface IProductService
    {
        PagedResult<Product> GetProductsByCategory(int categoryId, int pageIndex, int pageSize);
        IList<Product> GetAll();
        Product GetProductById(int? id);
        List<Image> GetImagesByProductId(int? productId);
        Category GetCategoryById(int? categoryId);
        Task CreateAsync(Product product);
        Task AddImage(Image image);
        Task SaveChangesAsync();
        PagedResult<Product> GetAllpage(int page, int pageSize, string searchTerm);
        Task<IList<ProductPriceDTO>> Dashboardlist();
        PagedResult<Product> GetAll_02(int page, int pageSize, string searchTerm, int? categoryid);

    }
}
