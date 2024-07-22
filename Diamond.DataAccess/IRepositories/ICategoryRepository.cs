using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.IRepositories
{
    public interface ICategoryRepository
    {
        IList<Category> GetAll();
        PagedResult<Category> GetAllpage(int page, int pageSize, string searchTerm);
        Task SaveChangesAsync();
        Task CreateAsync(Category category);
        Task DeleteAsync(Category category);
        Category Findid(int id);
        Task<int> GetCategoryCountAsync();
    }
}
