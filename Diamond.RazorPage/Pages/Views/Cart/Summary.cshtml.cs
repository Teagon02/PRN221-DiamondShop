using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Views.Cart
{
    [BindProperties]
    public class SummaryModel : PageModel
    {
        public IEnumerable<CartItem> ShoppingCartList { get; set; }
        public Order OrderHeader { get; set; }
        private readonly ICartService _cartService;
        private readonly IOrderService _orderService;
        public SummaryModel(ICartService cartService, IOrderService orderService)
        {
            _cartService = cartService;
            OrderHeader = new Order();
            _orderService = orderService;
        }
        public async Task OnGetAsync()
        {
            var cartList = await _cartService.GetCartItemsAsync();
            if (!cartList.Any())
            {
                ModelState.AddModelError(string.Empty, "Your cart is empty!");
            }
            ShoppingCartList = cartList;
            if (ShoppingCartList != null && ShoppingCartList.Any())
            {
                foreach (var cartItem in ShoppingCartList)
                {
                    OrderHeader.Total += (cartItem.Product.Price * cartItem.Quantity);
                }
            }

        }
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                ShoppingCartList = await _cartService.GetCartItemsAsync();
                if (!ShoppingCartList.Any())
                {
                    ModelState.AddModelError(string.Empty, "Your cart is empty!");
                    return Page();
                }
                foreach (var cartItem in ShoppingCartList)
                {
                    OrderHeader.Total += (cartItem.Product.Price * cartItem.Quantity);
                }
                await _orderService.CreateOrderAsync(ShoppingCartList.ToList(), OrderHeader);
                return RedirectToPage("ConfirmOrder");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Server Error");
                return Page();
            }


        }


    }
}
