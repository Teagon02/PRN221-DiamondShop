using Diamond.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.IRepositories
{
    public interface ICartItemRepository
    {
        Task<CartItem> AddCartItemAsync(CartItem cartItem);
        Task<CartItem> GetCartItemByUserIdAndProductIdAsync(int userId, int productId);
        Task<List<CartItem>> GetCartItemsByUserIdAsync(int userId);
        Task UpdateCartItemAsync(CartItem cartItem);
        Task DeleteCartItemAsync(int cartItemId);
    }

}
