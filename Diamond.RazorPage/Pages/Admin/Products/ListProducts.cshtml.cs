using Diamond.BusinessLogic.IServices;
using Diamond.BusinessLogic.Services;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Admin.Products
{
    public class ListProductsModel : PageModel
    {
        private readonly IProductService _productService;
        public PagedResult<Product> PageProducts { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; } = 4;
       
        public ListProductsModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet(int pageIndex = 1)
        {
            CurrentPage = pageIndex;
            PageProducts = _productService.GetAllpage(CurrentPage, PageSize);
            
        }
    }
}
