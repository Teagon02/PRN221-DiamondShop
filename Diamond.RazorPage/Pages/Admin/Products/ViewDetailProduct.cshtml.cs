using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Diamond.RazorPage.Pages.Admin.Products
{
    public class ViewDetailProductModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        [BindProperty]
        public ProductDTO ProductDTO { get; set; }

        public IList<Category> Categories { get; set; } // Initialize this properly

        public Product Product { get; set; }

        public string ErrorMessage { get; set; } = string.Empty;
        public string SuccessMessage { get; set; } = string.Empty;

        public ViewDetailProductModel(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task OnGet(int id)
        {
            Categories = _categoryService.GetAll(); // Populate Categories

            var product = _productService.GetProductById(id);
            var images = _productService.GetImagesByProductId(id);

            if (product == null)
            {
                Response.Redirect("/Admin/Products/ListProducts");
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
        }

        public async Task OnPost(int id)
        {
            if (id == 0) // Change this condition as per your business logic
            {
                Response.Redirect("/Admin/Products/ListProducts");
                return;
            }

            var product = _productService.GetProductById(id);
            var images = _productService.GetImagesByProductId(id);

            // Update the Product in database
            product.Name = ProductDTO.Name;
            product.Description = ProductDTO.Description;
            product.MainStoneSize = ProductDTO.MainStoneSize;
            product.SideStoneQuantity = ProductDTO.SideStoneQuantity;
            product.SideStoneType = ProductDTO.SideStoneType;
            product.SideStoneWeight = ProductDTO.SideStoneWeight;
            product.GoldType = ProductDTO.GoldType;
            product.GoldKarat = ProductDTO.GoldKarat;
            product.GoldWeight = ProductDTO.GoldWeight;
            product.Status = ProductDTO.Status;
            product.Price = ProductDTO.Price;
            product.DateModified = ProductDTO.DateModified;

            // Ensure CategoryId is set correctly
            product.CategoryId = ProductDTO.CategoryId;

            await _productService.SaveChangesAsync();

            // Handle image upload and deletion as per your commented-out code

            // Set success message and redirect
            SuccessMessage = "Product updated successfully";
            Response.Redirect("/Admin/Products/ListProducts");
        }


       
    }
}
