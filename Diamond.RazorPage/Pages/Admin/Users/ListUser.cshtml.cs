using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Admin.Users
{
    public class ListUserModel : PageModel
    {
        private readonly IUserService _userService;
        public PagedResult<User> PagedUsers { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; } = 4;
        public string SearchTerm { get; set; }

        public ListUserModel(IUserService userService)
        {
            _userService = userService;
        }

        public void OnGet(string searchTerm, int pageIndex = 1)
        {
            CurrentPage = pageIndex;
            SearchTerm = searchTerm;
            PagedUsers = _userService.GetAllPage(CurrentPage, PageSize, SearchTerm);
        }
    }
}
