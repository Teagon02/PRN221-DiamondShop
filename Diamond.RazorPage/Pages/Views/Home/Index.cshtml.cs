using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using System.Collections.Generic;

namespace Diamond.RazorPage.Pages.Views.Home
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public PagedResult<Product> PageProducts { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; } = 6;
        public string searchTerm { get; set; }
        public int? SelectedCategory { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public IndexModel(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public void OnGet(string searchTerm, int? category, int pageIndex = 1)
        {
            this.searchTerm = searchTerm;
            SelectedCategory = category;
            CurrentPage = pageIndex;

            Categories = _categoryService.GetAll();

            PageProducts = _productService.GetAll_02(CurrentPage, PageSize, searchTerm, category);

            foreach (var product in PageProducts.Items)
            {
                product.PriceFormatted = ConvertToVND(product.Price);
            }
        }

        private string ConvertToVND(double price)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            return string.Format(culture, "{0:#,##0} ", price);
        }
    }
}
