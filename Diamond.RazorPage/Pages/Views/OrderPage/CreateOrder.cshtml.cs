using System.Threading.Tasks;
using Diamond.DataAccess.Models;
using Diamond.BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Diamond.BusinessLogic.IServices;

namespace Diamond.RazorPage.Pages.Views.OrderPage
{
    public class CreateOrderModel : PageModel
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;

        public CreateOrderModel(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }

        [BindProperty]
        public Order Order { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Users = await _userService.GetUserSelectListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Users = await _userService.GetUserSelectListAsync();
                return Page();
            }

            await _orderService.CreateOrderAsync(Order);
            return RedirectToPage("/OrderPage");
        }
    }
}
