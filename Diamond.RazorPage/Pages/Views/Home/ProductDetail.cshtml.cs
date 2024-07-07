using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Diamond.DataAccess.PageList;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Views.Home
{
    public class ProductDetailModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public PagedResult<Product> PageProducts { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; } = 6;
        public ProductDetailModel(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService=categoryService;
        }
        [BindProperty]
        public ProductDTO ProductDTO { get; set; }

        public IList<Category> Categories { get; set; } // Initialize this properly

        public Product Product { get; set; }
        public IList<Product> Products { get; private set; }
        public Category Category { get; private set; }

        public void OnGet(int id , int pageIndex = 1)
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
            };

            Product = product;
            Product.Images = images;
            CurrentPage = pageIndex;
            PageProducts = _productService.GetProductsByCategory(product.CategoryId, CurrentPage, PageSize);

        }
        //public void OnGet(string categoryName)
        //{
        //    Products = _productService.GetProductByCategory(categoryName);

        //}

    }
}
