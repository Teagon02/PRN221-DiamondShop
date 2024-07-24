using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Data;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Diamond.BusinessLogic.Services
{
    public class CartService : ICartService
    {
        private readonly DiamondDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartService(DiamondDbContext dbContext, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        private string GetUserId()
        {
            return _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
        }
        public async Task AddToCartAsync(int productId, int quantity)
        {
            var userId = GetUserId();
            var cartItem = await _dbContext.CartItems.FirstOrDefaultAsync(ci => ci.ProductId == productId && ci.UserId == userId);

            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                var product = await _dbContext.Products.FindAsync(productId);
                if (product != null)
                {
                    cartItem = new CartItem
                    {
                        ProductId = productId,
                        Product = product,
                        Quantity = quantity,
                        UserId = userId
                    };
                    await _dbContext.CartItems.AddAsync(cartItem);
                }
            }

            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<CartItem>> GetCartItemsAsync()
        {
            var userId = GetUserId();
            return await _dbContext.CartItems.Include(ci => ci.Product).Where(ci => ci.UserId == userId).ToListAsync();
        }

        public async Task UpdateCartAsync(int cartItemId, int quantity)
        {
            var cartItem = await _dbContext.CartItems.FindAsync(cartItemId);
            if (cartItem != null)
            {
                cartItem.Quantity = quantity;
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task RemoveFromCartAsync(int cartItemId)
        {
            var cartItem = await _dbContext.CartItems.FindAsync(cartItemId);
            if (cartItem != null)
            {
                _dbContext.CartItems.Remove(cartItem);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
