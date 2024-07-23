using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages
{
    public class ConfirmEmailModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        [BindProperty]
        public string Message { get; set; }

        public ConfirmEmailModel(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IActionResult> OnGetAsync(Guid userId, string token)
        {
            var user = await userManager.FindByIdAsync(userId.ToString());
            if (user != null)
            {
                var result = await this.userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    Message = "Email address is successfully confimred, you can now try to login";
                    return Page();
                }
            }
            this.Message = "Failed to validate email.";
            return Page();
        }
    }
}
