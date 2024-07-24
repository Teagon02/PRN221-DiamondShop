using Diamond.DataAccess.Models;

namespace Diamond.BusinessLogic.IServices
{
    public interface ICartService
    {
        Task AddToCartAsync(int productId, int quantity);
        Task<List<CartItem>> GetCartItemsAsync();
        Task UpdateCartAsync(int cartItemId, int quantity);
        Task RemoveFromCartAsync(int cartItemId);
    }
}
