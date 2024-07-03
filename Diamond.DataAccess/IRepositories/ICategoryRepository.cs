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
        PagedResult<Category> GetAll(int page, int pageSize);
        Task SaveChangesAsync();
        Task CreateAsync(Category category);
        Task DeleteAsync(Category category);
        Category Findid(int id);
    }
}
