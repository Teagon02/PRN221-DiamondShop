using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Data;
using Diamond.DataAccess.IRepositories;
using Diamond.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Diamond.BusinessLogic.Services
{
    public class CartItemService : ICartItemService
    {
        private readonly ICartItemRepository _cartItemRepository;
        private readonly IProductRepository _productRepository;
        private readonly DiamondDbContext _context;

        public CartItemService(ICartItemRepository cartItemRepository, IProductRepository productRepository, DiamondDbContext context)
        {
            _cartItemRepository = cartItemRepository;
            _productRepository = productRepository;
            _context = context;
        }

        public async Task<CartItem> AddProductToCartAsync(int userId, int productId, int quantity)
        {
            // Check if the product exists
            var product = _productRepository.GetProductById(productId);
            if (product == null)
                throw new InvalidOperationException("Product does not exist.");

            // Check if the cart item already exists
            var existingCartItem = await _cartItemRepository.GetCartItemByUserIdAndProductIdAsync(userId, productId);
            if (existingCartItem != null)
            {
                // If exists, update the quantity
                existingCartItem.Quantity += quantity;
                await _cartItemRepository.UpdateCartItemAsync(existingCartItem);
                return existingCartItem;
            }
            else
            {
                // Otherwise, create a new cart item
                var newCartItem = new CartItem
                {
                    Id = userId,
                    ProductId = productId,
                    Quantity = quantity,
                    Price = product.Price  // Assuming the price is directly taken from the product
                };
                await _cartItemRepository.AddCartItemAsync(newCartItem);
                return newCartItem;
            }
        }

        public async Task<CartItem> GetCartItemByUserIdAndProductIdAsync(int userId, int productId)
        {
            return await _cartItemRepository.GetCartItemByUserIdAndProductIdAsync(userId, productId);
        }

        public async Task<List<CartItem>> GetCartItemsByUserIdAsync(int userId)
        {
            var cartItems = await _context.CartItems
                 .Where(ci => ci.Id == userId)
                 .Include(ci => ci.Products)
                 .ThenInclude(p => p.Images)
                 .ToListAsync();

            return cartItems;
        }

        public async Task RemoveProductFromCartAsync(int userId, int productId)
        {
            var cartItem = await _cartItemRepository.GetCartItemByUserIdAndProductIdAsync(userId, productId);
            if (cartItem == null)
                throw new InvalidOperationException("Cart item does not exist.");

            await _cartItemRepository.DeleteCartItemAsync(cartItem.Id);
        }

        public async Task UpdateProductQuantityInCartAsync(int userId, int productId, int quantity)
        {
            var cartItem = await _cartItemRepository.GetCartItemByUserIdAndProductIdAsync(userId, productId);
            if (cartItem == null)
                throw new InvalidOperationException("Cart item does not exist.");

            cartItem.Quantity = quantity;
            await _cartItemRepository.UpdateCartItemAsync(cartItem);
        }

        public async Task ClearCartAsync(int userId)
        {
            var cartItems = await _cartItemRepository.GetCartItemsByUserIdAsync(userId);
            foreach (var item in cartItems)
            {
                await _cartItemRepository.DeleteCartItemAsync(item.Id);
            }
        }
    }
}
