using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace Diamond.RazorPage.Pages.Views.Home
{
    public class ProductDetailModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ICartService _cartService;
        public PagedResult<Product> PageProducts
        { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; } = 6;

        public ProductDetailModel(IProductService productService, ICategoryService categoryService, ICartService cartService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _cartService = cartService;
        }

        [BindProperty]
        public ProductDTO ProductDTO { get; set; }

        public IList<Category> Categories { get; set; } // Initialize this properly

        public Product Product { get; set; }
        public IList<Product> Products { get; private set; }
        public Category Category { get; private set; }

        public void OnGet(int id, int pageIndex = 1)
        {
            Categories = _categoryService.GetAll(); // Populate Categories

            var product = _productService.GetProductById(id);
            var images = _productService.GetImagesByProductId(id);

            if (product == null)
            {
                Response.Redirect("/Views/Home/Index");
                return;
            }

            ProductDTO = new ProductDTO()
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                MainStoneSize = product.MainStoneSize,
                SideStoneQuantity = product.SideStoneQuantity,
                SideStoneType = product.SideStoneType,
                SideStoneWeight = product.SideStoneWeight,
                GoldType = product.GoldType,
                GoldKarat = product.GoldKarat,
                GoldWeight = product.GoldWeight,
                Status = product.Status,
                Price = product.Price,
                DateCreated = product.DateCreated,
                DateModified = product.DateModified,
                ImageUrls = images.Select(i => i.Url).ToList(),
                Images = new List<IFormFile>(),
                CategoryId = product.CategoryId,
                PriceInVND = ConvertToVND(product.Price)
            };

            Product = product;
            Product.Images = images;
            CurrentPage = pageIndex;
            PageProducts = _productService.GetProductsByCategory(product.CategoryId, CurrentPage, PageSize);

            foreach (var similarProduct in PageProducts.Items)
            {
                similarProduct.PriceFormatted = ConvertToVND(similarProduct.Price);
            }
        }

        private string ConvertToVND(double price)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            return string.Format(culture, "{0:#,##0}", price);
        }
        public async Task<IActionResult> OnPostAddToCartAsync(int productId, int quantity)
        {
            await _cartService.AddToCartAsync(productId, quantity);
            return RedirectToPage();
        }
    }
}
