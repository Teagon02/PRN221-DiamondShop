using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IMailService mailService;

        [BindProperty]
        public RegisterUserDto RegisterViewModel { get; set; }
        public RegisterModel(UserManager<IdentityUser> userManager, IMailService mailService)
        {
            this.userManager = userManager;
            this.mailService = mailService;
        }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = RegisterViewModel.Email,
                    Email = RegisterViewModel.Email,
                    PhoneNumber = RegisterViewModel.Phone,

                };

                var identityResult = await userManager.CreateAsync(user, RegisterViewModel.Password);

                if (identityResult.Succeeded)
                {
                    var tokenConfirm = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    var addRolesResult = await userManager.AddToRoleAsync(user, "Customer");

                    if (addRolesResult.Succeeded)
                    {
                        TempData["Notification"] = new Notification
                        {
                            Type = DataAccess.Models.enums.NotificationType.Success,
                            Message = "User registered successfully, Please check your email to confirm your accout"
                        };

                    }
                    var confirmLink = Url.PageLink(pageName: "/ConfirmEmail", values: new { userId = user.Id, token = tokenConfirm });
                    var message = new MessageDto(new string[] { user.Email }, "Confirmation Email Link", $"Please confirm your account by <a href='{confirmLink}'>clicking here</a>.");
                    await mailService.SendEmailAsync(message);
                    return RedirectToPage("/Login");
                }

                ViewData["Notification"] = new Notification
                {
                    Type = DataAccess.Models.enums.NotificationType.Error,
                    Message = "Something went wrong."
                };

                return Page();
            }
            else
            {
                return Page();
            }
        }
    }
}
