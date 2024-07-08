using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Views.Home
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;
        public PagedResult<Product> PageProducts { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; } = 6;
        public string searchTerm { get; set; }
        public IndexModel(IProductService productService)
        {
            _productService=productService;
        }

        public void OnGet( string searchterm ,int pageIndex = 1 )
        {
            searchTerm = searchterm;
            CurrentPage = pageIndex;
            PageProducts = _productService.GetAll_02(CurrentPage, PageSize ,searchTerm);
        }
    }
}
