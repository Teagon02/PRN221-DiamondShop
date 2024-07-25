using Diamond.DataAccess.Data;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.IRepositories;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DiamondDbContext _dbContext;

        public UserRepository(DiamondDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //Start List User
        public IList<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }
        //EndList User



        //Start Add New User
     
        public async Task CreateAsync(User user)
        {
           await _dbContext.Users.AddAsync(user);
           await _dbContext.SaveChangesAsync();
        }
      
        //End Create User



        //Get id for User
        public User GetUserById(int id)
        {
          var user =  _dbContext.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }

        //save change
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();    
        }

        public void Delete(User user)
        {
            var user1 = _dbContext.Remove(user);
            
        }

        public PagedResult<User> GetAllPage(int page, int pageSize, string searchTerm)
        {
            var query = _dbContext.Users.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(u => u.Name.Contains(searchTerm)); // Thay đổi ở đây để kiểm tra searchTerm có tồn tại hay không
            }

            var totalItems = query.Count();
            var users = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return new PagedResult<User>
            {
                Items = users,
                TotalItems = totalItems,
                PageNumber = page,
                PageSize = pageSize
            };
        }

        public async Task<int> GetUerCount()
        {
            return await _dbContext.Users.CountAsync();
        }
    }
}
