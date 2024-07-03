using Diamond.BusinessLogic.IServices;
using Diamond.BusinessLogic.Services;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Diamond.RazorPage.Pages.Admin.Products
{
    public class CreateProductModel : PageModel
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IProductService _ProductService;
        private readonly ICategoryService _CategoryService;

        public CreateProductModel(IWebHostEnvironment webHostEnvironment, IProductService ProductService, ICategoryService categoryService)
        {
            _webHostEnvironment=webHostEnvironment;
            _ProductService=ProductService;
            _CategoryService=categoryService;
        }
        [BindProperty]
        public ProductDTO ProductDTO { get; set; }
        public IList<Category> Categories { get; set; }
        public ImageDTO ImageDTO { get; set; }

        public void OnGet()
        {
            Categories =  _CategoryService.GetAll();
            ProductDTO = new ProductDTO();
            ImageDTO = new ImageDTO();
        }
        public string erroMessage = "";
        public string successMessage = "";
        public async Task<IActionResult> OnPostAsync(ImageDTO imageDTO)
        {
            
            var product = new Product
            {
                Name = ProductDTO.Name,
                Description = ProductDTO.Description,
                MainStoneSize = ProductDTO.MainStoneSize,
                SideStoneQuantity = ProductDTO.SideStoneQuantity,
                SideStoneType = ProductDTO.SideStoneType,
                SideStoneWeight = ProductDTO.SideStoneWeight,
                GoldType = ProductDTO.GoldType,
                GoldKarat = ProductDTO.GoldKarat,
                GoldWeight = ProductDTO.GoldWeight,
                Status = ProductDTO.Status,
                Price = ProductDTO.Price,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                CategoryId = ProductDTO.CategoryId
            };

            // Call your ProductService to create the product
            await _ProductService.CreateAsync(product);
            await _ProductService.SaveChangesAsync();

            // Add images after the product has been created
            foreach (var item in imageDTO.Images)
            {
                string stringfileName = UploadFile(item);
                var productImage = new DataAccess.Models.Image
                {
                    Url = stringfileName,
                    ProductId = product.ProductId, // Use the Id of the newly created product
                    Description = product.Description,
                };
                await _ProductService.AddImage(productImage);
            }
            await _ProductService.SaveChangesAsync();

            // Clear ProductDTO fields after successful creation
            ProductDTO.Name = "";
            ProductDTO.Description ="";
            ProductDTO.Price = 0;
            ProductDTO.MainStoneSize="";
            ProductDTO.SideStoneWeight =0;
            ProductDTO.SideStoneQuantity =0;
            ProductDTO.GoldType = "";
            ProductDTO.GoldKarat="";
            ProductDTO.GoldWeight =0;
            ProductDTO.Status =false;


            ModelState.Clear();
            successMessage = "Product created successfully";
            return RedirectToPage("/Admin/Products/ListProducts");
        }

        private string UploadFile(IFormFile item)
        {
            string fileName = null;
            if (item != null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "products");
                fileName = Guid.NewGuid().ToString() + "-" + item.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    item.CopyTo(fileStream);
                }
            }
            return fileName;
        }

    }

}
