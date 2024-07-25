using Diamond.DataAccess.Data;
using Diamond.DataAccess.IRepositories;
using Diamond.DataAccess.Models;

namespace Diamond.DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DiamondDbContext _dbContext;
        public OrderRepository(DiamondDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Update(Order order)
        {
            _dbContext.Orders.Update(order);
            _dbContext.SaveChanges();
        }
    }
}
