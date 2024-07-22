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
    public interface IUserService
    {

        IList<User> GetAll();
        Task CreateAsync(User user);

        User GetUserById(int id);
        void Delete(User user);
        Task SaveChangesAsync();
        PagedResult<User> GetAllPage(int page, int pageSize, string searchTerm);
        Task<int> GetUserCountAsync();

    }

 
}
