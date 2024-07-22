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
    public interface ICategoryService
    {
        IList<Category> GetAll();
        Task CreateAsync(Category category);
        PagedResult<Category> GetAllpage(int page, int pageSize , string searchTerm);
        Category Findid(int id);
        Task DeleteAsync(Category category);
        Task<int> GetCategoryCountAsync();
        Task SaveChangesAsync();
    }
}
