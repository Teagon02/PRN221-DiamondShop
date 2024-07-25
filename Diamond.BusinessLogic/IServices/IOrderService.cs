using Diamond.DataAccess.Models;

namespace Diamond.BusinessLogic.IServices
{
    public interface IOrderService
    {
        string GetUserId();
        Task CreateOrderAsync(List<CartItem> cartItems, Order order);
        Task ClearCartAsync();
       

    }
}
