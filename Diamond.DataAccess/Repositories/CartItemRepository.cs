using Diamond.DataAccess.Data;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.IRepositories;
using Diamond.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly DiamondDbContext _context;
        public CartItemRepository(DiamondDbContext context)
        {
            _context = context;
        }
        public async Task<CartItem> AddCartItemAsync(CartItem cartItem)
        {
            await _context.CartItems.AddAsync(cartItem);
            await _context.SaveChangesAsync();
            return cartItem;
        }
        public async Task<CartItem> GetCartItemByUserIdAndProductIdAsync(int userId, int productId)
        {
            return await _context.CartItems
                                 .Where(ci => ci.Id == userId && ci.ProductId == productId)
                                 .FirstOrDefaultAsync();
        }
        public async Task<List<CartItem>> GetCartItemsByUserIdAsync(int userId)
        {
            return await _context.CartItems
                                 .Where(ci => ci.Id == userId)
                                 .ToListAsync();
        }
        public async Task UpdateCartItemAsync(CartItem cartItem)
        {
            _context.Entry(cartItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteCartItemAsync(int cartItemId)
        {
            var cartItem = await _context.CartItems.FindAsync(cartItemId);
            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
                await _context.SaveChangesAsync();
            }
        }
    }
}
