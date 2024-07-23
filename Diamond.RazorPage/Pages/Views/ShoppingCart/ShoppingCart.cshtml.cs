using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Security.Claims;

namespace Diamond.RazorPage.Pages.Views.ShoppingCart
{
    [Authorize]  // Ensures only logged-in users can access cart operations
    public class ShoppingCartModel : PageModel
    {
        private readonly ICartItemService _cartService;

        public List<CartItem> CartItems { get; set; }
        public double CartTotal { get; set; }

        [BindProperty]
        public int ProductIdToRemove { get; set; }

        public ShoppingCartModel(ICartItemService cartService)
        {
            _cartService = cartService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            int userId = GetUserId();
            if (userId == 0)
            {
                return RedirectToPage("/Error"); // Or any other error handling mechanism
            }

            CartItems = await _cartService.GetCartItemsByUserIdAsync(userId);
            CartTotal = CalculateCartTotal(CartItems);
            return Page();
        }

        public async Task<IActionResult> OnPostAddToCartAsync(int productId, int quantity)
        {
            int userId = GetUserId();
            if (userId == 0)
            {
                return RedirectToPage("/Error"); // Or handle this situation appropriately
            }

            try
            {
                await _cartService.AddProductToCartAsync(userId, productId, quantity);
                TempData["SuccessMessage"] = "Product added to cart successfully.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error adding product to cart: {ex.Message}";
            }
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostRemoveFromCartAsync()
        {
            int userId = GetUserId();
            if (userId == 0)
            {
                return RedirectToPage("/Error"); // Or handle this situation appropriately
            }

            try
            {
                await _cartService.RemoveProductFromCartAsync(userId, ProductIdToRemove);
                TempData["SuccessMessage"] = "Product removed from cart successfully.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error removing product from cart: {ex.Message}";
            }
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostUpdateCartAsync(int productId, int newQuantity)
        {
            int userId = GetUserId();
            if (userId == 0)
            {
                return RedirectToPage("/Error"); // Or handle this situation appropriately
            }

            try
            {
                await _cartService.UpdateProductQuantityInCartAsync(userId, productId, newQuantity);
                TempData["SuccessMessage"] = "Cart updated successfully.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error updating cart: {ex.Message}";
            }
            return RedirectToPage();
        }

        private double CalculateCartTotal(List<CartItem> cartItems)
        {
            return cartItems?.Sum(item => item.Price * item.Quantity) ?? 0;
        }

        private int GetUserId()
        {
            // Extract the user ID from the claims, assuming it's stored as "UserId"
            return User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value.Count() ?? 0;
        }
    }
}
