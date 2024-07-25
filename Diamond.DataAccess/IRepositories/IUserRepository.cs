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
    public interface IUserRepository
    {
        IList<User> GetAll();
        Task CreateAsync(User user);
        User GetUserById(int id);
        Task SaveChangesAsync();
        void Delete(User user);
        PagedResult<User> GetAllPage(int page, int pageSize, string searchTerm);
        Task<int> GetUerCount();

    }
}
