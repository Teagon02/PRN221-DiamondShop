using Diamond.DataAccess.Data;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Diamond.RazorPage.Pages.OrderPage
{
    public class OrderModel : PageModel
    {
        private readonly DiamondDbContext _context;

        public OrderModel(DiamondDbContext context)
        {
            _context = context;
        }

        public OrderViewModel Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var order = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefaultAsync(o => o.OrderId == id);

            if (order == null)
            {
                return NotFound();
            }

            Order = new OrderViewModel
            {
                OrderId = order.OrderId,
                CustomerName = order.User.Name,
                CustomerEmail = order.User.Email,
                CustomerPhone = order.User.Phone.ToString(),
                CustomerAddress = order.User.Address,
                DateCreated = order.DateCreated,
                Total = order.Total,
                OrderItems = order.OrderItems.Select(oi => new OrderItemViewModel
                {
                    ProductName = oi.Product.Name,
                    Quantity = oi.Quantity,
                    Price = oi.Product.Price
                }).ToList()
            };
            return Page();
        }
        public class OrderViewModel
        {
            public int OrderId { get; set; }
            public string CustomerName { get; set; }
            public string CustomerEmail { get; set; }
            public string CustomerPhone { get; set; }
            public string CustomerAddress { get; set; }
            public List<OrderItemViewModel> OrderItems { get; set; }
            public double Total { get; set; }
            public DateTime DateCreated { get; set; }
        }
        public class OrderItemViewModel
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }
        }
    }
}
