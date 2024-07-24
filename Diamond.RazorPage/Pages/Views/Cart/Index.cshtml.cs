using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Views.Cart
{
    public class IndexModel : PageModel
    {
        private readonly ICartService _cartService;

        public IndexModel(ICartService cartService)
        {
            _cartService = cartService;
        }

        public List<CartItem> CartItems { get; set; }
        public decimal CartTotal { get; set; }

        public async Task OnGetAsync()
        {
            CartItems = await _cartService.GetCartItemsAsync();
            CartTotal = (decimal)CartItems.Sum(ci => ci.Product.Price * ci.Quantity);
        }

        public async Task<IActionResult> OnPostUpdateAsync(int cartItemId, int quantity)
        {
            await _cartService.UpdateCartAsync(cartItemId, quantity);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostRemoveAsync(int cartItemId)
        {
            await _cartService.RemoveFromCartAsync(cartItemId);
            return RedirectToPage();
        }
    }
}
