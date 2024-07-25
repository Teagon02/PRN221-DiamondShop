using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;

namespace Diamond.DataAccess.IRepositories
{
    public interface IOrderRepository
    {
        void Update(Order order);
        Task<int> GetOrderCount();
        Task<IList<OrderDTO>> GetOrderList();
    }
}
