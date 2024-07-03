using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Data;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;

namespace Diamond.RazorPage.Pages.Admin.Users
{
    public class CreateUserModel : PageModel
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUserService _userService;
        private readonly ILogger<CreateUserModel> _logger;

        [BindProperty]
        public UserDTO UserDTO { get; set; } = new UserDTO();

        public CreateUserModel(IWebHostEnvironment webHostEnvironment, IUserService userService,
            ILogger<CreateUserModel> logger )
        {
            _webHostEnvironment = webHostEnvironment;
            _userService = userService;
            _logger = logger;
      
        }

        public string erroMessage { get; set; } = string.Empty;
        public string successMessage { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (UserDTO.Avatar == null)
            {
                ModelState.AddModelError("UserDTO.Avatar", "The image file is required");
                erroMessage = "Please provide all the required fields!";
                return Page();
            }

            if (!ModelState.IsValid)
            {
                erroMessage = "Please provide all the required fields!";
                return Page();
            }

            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            newFileName += Path.GetExtension(UserDTO.Avatar!.FileName);

            string imageFullPath = _webHostEnvironment.WebRootPath +"/users/"+newFileName;


            using (var stream = System.IO.File.Create(imageFullPath))
            {
                UserDTO.Avatar.CopyTo(stream);
            }
            User user = new User()
            {
                Email = UserDTO.Email,
                Name = UserDTO.Name,
                Password = UserDTO.Password,
                Address = UserDTO.Address,
                Avatar = newFileName,
                CreateOn = DateTime.Now,
                Status = UserDTO.Status,
                Phone = UserDTO.Phone,
            };
           await  _userService.CreateAsync(user);
          await   _userService.SaveChangesAsync();

            UserDTO.Email = "";
            UserDTO.Name = "";
            UserDTO.Password = "";
            UserDTO.Address ="";
            UserDTO.Avatar = null;
            UserDTO.Status = false;
            UserDTO.Phone = 0;
            ModelState.Clear();

            successMessage = "User created successfully";
            Response.Redirect("/Admin/Users/ListUser");

          


            return Page();
        }
    }
}
