using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Diamond.RazorPage.Pages.Views.Contact
{
    public class ContactModel : PageModel
    {
        private readonly IMailService _mailService;
        public ContactModel(IMailService mailService)
        {
            _mailService = mailService;
        }
        public void OnGet()
        {
        }
        [BindProperty]
        [Required]
        public string Name { get; set; }

        [BindProperty]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [BindProperty]
        [Required]
        public string Message { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var body = $"Name: {Name} <br> Email: {Email} <br> Message: {Message}";
            var message = new MessageDto(new string[] { "quocdai904@gmail.com" }, "Contact Us Form Submission", body);
            await _mailService.SendEmailAsync(message);

            return RedirectToPage("ContactConfirmation");
        }
    }
}
