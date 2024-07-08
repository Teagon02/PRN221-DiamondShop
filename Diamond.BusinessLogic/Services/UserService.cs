using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.IRepositories;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Diamond.BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

      
        public async Task CreateAsync(User user)
        {
             await _userRepository.CreateAsync(user);
        }
        public IList<User> GetAll()
        {
            return _userRepository.GetAll();
        }

   

        public User GetUserById(int id)
        {
          return _userRepository.GetUserById(id);
        }

        public Task UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
        public async Task SaveChangesAsync()
        {
            await _userRepository.SaveChangesAsync();
        }

        public void Delete(User user)
        {
           _userRepository.Delete(user);
        }



        public PagedResult<User> GetAllPage(int page, int pageSize, string searchTerm)
        {
            var page1 = _userRepository.GetAllPage(page, pageSize,searchTerm);
            return page1;
        }
    }
}
