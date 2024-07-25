using Diamond.DataAccess.Data;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.IRepositories;
using Diamond.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Diamond.DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DiamondDbContext _dbContext;
        public OrderRepository(DiamondDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       

        public async Task<int> GetOrderCount()
        {
           return await _dbContext.Orders.CountAsync();
        }

      

        public void Update(Order order)
        {
            _dbContext.Orders.Update(order);
            _dbContext.SaveChanges();
        }

      public async  Task<IList<OrderDTO>> GetOrderList()
        {
            return await _dbContext.Orders
                .Include(o => o.User)
                
                
                // Include the User data
                .Select(order => new OrderDTO
                {
                    OrderId = order.OrderId,
                    UserName = order.User.UserName, // Assuming IdentityUser has UserName
                    Total = order.Total,
                    Status = order.Status,
                    Comments = order.Comments,
                    DateCreated = order.DateCreated,
                    PhoneNumber = order.PhoneNumber,
                   
                }).ToListAsync();
        }
    }
}
