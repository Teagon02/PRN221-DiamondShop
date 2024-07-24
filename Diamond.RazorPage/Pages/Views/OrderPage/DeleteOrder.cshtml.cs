using System.Threading.Tasks;
using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Models;
using Diamond.BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Views.OrderPage
{
    public class DeleteOrderModel : PageModel
    {
        private readonly IOrderService _orderService;

        public DeleteOrderModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [BindProperty]
        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int orderId)
        {
            Order = await _orderService.GetOrderByIdAsync(orderId);
            if (Order == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int orderId)
        {
            var order = await _orderService.GetOrderByIdAsync(orderId);
            if (order == null)
            {
                return NotFound();
            }

            await _orderService.DeleteOrderAsync(orderId);
            return RedirectToPage("/Orders");
        }
    }
}
