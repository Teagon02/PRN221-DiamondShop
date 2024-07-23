using Diamond.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.BusinessLogic.IServices
{
    public interface ICartItemService
    {
        Task<CartItem> AddProductToCartAsync(int userId, int productId, int quantity);
        Task<CartItem> GetCartItemByUserIdAndProductIdAsync(int userId, int productId);
        Task<List<CartItem>> GetCartItemsByUserIdAsync(int userId);
        Task RemoveProductFromCartAsync(int userId, int productId);
        Task UpdateProductQuantityInCartAsync(int userId, int productId, int quantity);
        Task ClearCartAsync(int userId);
    }

}
