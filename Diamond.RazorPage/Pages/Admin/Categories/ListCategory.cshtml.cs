using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Admin.Categories
{
    public class ListCategoryModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public PagedResult<Category> Pagedcategories { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; } = 4;
        public string SearchTerm { get; set; }

        public ListCategoryModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public void OnGet(string searchTerm, int pageIndex = 1)
        {
            CurrentPage = pageIndex;
            SearchTerm = searchTerm;
            Pagedcategories = _categoryService.GetAllpage(CurrentPage, PageSize, SearchTerm);
        }
    }
}
