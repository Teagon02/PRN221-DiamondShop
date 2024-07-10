using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Diamond.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Admin.Users
{
    [Authorize(Roles = SD.Role_Admin)]
    public class UpdateUserModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        [BindProperty]
        public UserDTO UserDTO { get; set; }
        public User User { get; set; }
        public string errorMessage = "";
        public string successMessage = "";
        public UpdateUserModel(IUserService userService, IWebHostEnvironment webHostEnvironment)
        {
            _userService = userService;
            _webHostEnvironment = webHostEnvironment;
        }
        public void OnGet(int id)
        {
            if (id == null)
            {
                Response.Redirect("/Admin/Users/ListUser");

            }
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                Response.Redirect("/Admin/Users/ListUser");
            }
            UserDTO = new UserDTO
            {
                
                Name = user.Name,
                Email = user.Email,
                Address = user.Address,

                Password = user.Password,
                Phone = user.Phone,
                Status = user.Status
            };
            User = user;
        }
        //update user in database
        public void OnPost(int id)
        {
            if(id == null)
            {
                Response.Redirect("/Admin/Users/ListUser");
                return;
            }
            if (!ModelState.IsValid)
            {
                errorMessage ="Please provid all the required fields";
            }
            var user = _userService.GetUserById(id);

            //update the image file if we have a new image file

            string newFileName = user.Avatar;
            if(UserDTO.Avatar != null)
            {
                newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                newFileName += Path.GetExtension(UserDTO.Avatar.FileName);
                string imageFullPath = _webHostEnvironment.WebRootPath + "/users/" + newFileName;

                using(var stream =System.IO.File.Create(imageFullPath))
                {
                    UserDTO.Avatar.CopyTo(stream);
                }
                //delete the old image
                string oldImageFullPath = _webHostEnvironment.WebRootPath + "/users/" + user.Avatar;
                System.IO.File.Delete(oldImageFullPath);    
            }
            //update the user in database
            user.Name = UserDTO.Name;
            user.Email = UserDTO.Email;
            user.Address = UserDTO.Address;
            user.Avatar = newFileName;
            user.Status = UserDTO.Status;
            user.Phone = UserDTO.Phone;
            _userService.SaveChangesAsync();


            User = user;
            successMessage = "User updated successfully";
            Response.Redirect("/Admin/Users/ListUser");
        }
    }
}


