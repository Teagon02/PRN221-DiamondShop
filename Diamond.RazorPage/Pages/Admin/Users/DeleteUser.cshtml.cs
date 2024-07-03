using Diamond.BusinessLogic.IServices;
using Diamond.BusinessLogic.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Admin.Users
{
    public class DeleteUserModel : PageModel
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUserService _userservice;
        public  DeleteUserModel(IWebHostEnvironment webHostEnvironment, IUserService userService)
        {
            _webHostEnvironment = webHostEnvironment;
            _userservice = userService;
        }
        public void OnGet(int id)
        {
           if (id == null)
            {
                Response.Redirect("/Admin/Users/ListUser");
                return;
            }
           var user = _userservice.GetUserById(id);
            if(user == null)
            {
                Response.Redirect("/Admin/Users/ListUser");
                return;
            }
            string imageFullPath = _webHostEnvironment.WebRootPath + "/users/" +user.Avatar;
            System.IO.File.Delete(imageFullPath);
            _userservice.Delete(user);
            _userservice.SaveChangesAsync();
            Response.Redirect("/Admin/Users/ListUser");
        }
    }
}
