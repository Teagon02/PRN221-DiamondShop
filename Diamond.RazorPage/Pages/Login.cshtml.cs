using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.Models.enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]
        public LoginUserDto LoginViewModel { get; set; }
        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var signInResult = await signInManager.PasswordSignInAsync(
                LoginViewModel.UserName, LoginViewModel.Password, false, false);

                if (signInResult.Succeeded)
                {
                    //if (!string.IsNullOrWhiteSpace(ReturnUrl))
                    //{
                    //    return RedirectToPage(ReturnUrl);
                    //}

                    return RedirectToPage("Index");
                }
                else
                {
                    ViewData["Notification"] = new Notification
                    {
                        Type = NotificationType.Error,
                        Message = "Unable to login"
                    };

                    return Page();
                }
            }

            return Page();


        }
    }
}
