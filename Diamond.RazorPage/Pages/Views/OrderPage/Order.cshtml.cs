using Diamond.BusinessLogic.IServices;
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
        private readonly IOrderService _orderService;

        public OrderModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [BindProperty(SupportsGet = true)]
        public int OrderId { get; set; }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Order = await _orderService.GetOrderByIdAsync(OrderId);

            if (Order == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
