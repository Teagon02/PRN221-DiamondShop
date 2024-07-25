using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Data;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Diamond.BusinessLogic.Services
{
    public class OrderService : IOrderService
    {
        private readonly DiamondDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public OrderService(DiamondDbContext dbContext,
UserManager<IdentityUser> userManager,
IHttpContextAccessor httpContextAccessor)
        {

            _dbContext = dbContext;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task ClearCartAsync()
        {
            var userId = GetUserId();
            var cartItems = _dbContext.CartItems.Where(ci => ci.UserId == userId);
            _dbContext.CartItems.RemoveRange(cartItems);
            await _dbContext.SaveChangesAsync();
        }

        public async Task CreateOrderAsync(List<CartItem> cartItems, Order order)
        {
            var userId = GetUserId();
            var orderNew = new Order()
            {
                UserId = userId,
                Total = order.Total,
                Status = "active",
                DateCreated = DateTime.Now,
                Comments = order.Comments,
                TransactionId = null,
                PickupName = order.PickupName,
                PhoneNumber = order.PhoneNumber,
                OrderItems = cartItems.Select(ci => new OrderItem
                {
                    ProductId = ci.ProductId,
                    Quantity = ci.Quantity,
                    Price = ci.Product.Price,
                    Name = ci.Product.Name,
                    DateCreated = DateTime.Now,

                }).ToList()
            };
            _dbContext.Orders.Add(orderNew);
            await _dbContext.SaveChangesAsync();

        }

     

        public string GetUserId()
        {
            return _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
        }
    }
}
