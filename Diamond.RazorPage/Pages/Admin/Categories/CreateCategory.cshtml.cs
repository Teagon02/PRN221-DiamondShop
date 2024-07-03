using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Admin.Categories
{
    public class CreateCategoryModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public CreateCategoryModel(ICategoryService categoryService)
        {
            _categoryService=categoryService;
        }
        public string erroMessage { get; set; } = string.Empty;
        public string successMessage { get; set; } = string.Empty;
        [BindProperty]
        public CategoryDTO CategoryDTO { get; set; }
        public void OnGet()
        {
            CategoryDTO = new CategoryDTO();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            
            if (!ModelState.IsValid)
            {
                erroMessage = "Please provide all the required fields!";
                return Page();
            }
            Category category = new Category()
            {
                CategoryName = CategoryDTO.CategoryName,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                Description = CategoryDTO.Description,
            };
            await _categoryService.CreateAsync(category);
            await _categoryService.SaveChangesAsync();
            CategoryDTO.CategoryName = "";
            CategoryDTO.Description = "";
            ModelState.Clear();
            successMessage = "Category created successfully";
            Response.Redirect("/Admin/Categories/ListCategory");
            return Page();
        }
    }
}
