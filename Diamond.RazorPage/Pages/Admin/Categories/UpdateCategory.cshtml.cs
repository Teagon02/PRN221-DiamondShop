using Diamond.BusinessLogic.IServices;
using Diamond.BusinessLogic.Services;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Admin.Categories
{
    public class UpdateCategoryModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public UpdateCategoryModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [BindProperty]
        public CategoryDTO CategoryDTO { get; set; }

        public Category Category { get; set; }
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet(int id)
        {
            var category = _categoryService.Findid(id);
            if (category == null)
            {
                Response.Redirect("/Admin/Categories/ListCategory");
                return;
            }

            CategoryDTO = new CategoryDTO
            {
                CategoryName = category.CategoryName,
                Description = category.Description,
            };

            Category = category;
        }
        public void OnPost(int id)
        {
            if (id == null)
            {
                Response.Redirect("/Admin/Categories/ListCategory");
                return;
            }
            if (!ModelState.IsValid)
            {
                errorMessage ="Please provide all the required fields";
            }
            var category = _categoryService.Findid(id);



            //update the user in database
            category.CategoryName = CategoryDTO.CategoryName;
            category.Description = CategoryDTO.Description;
            _categoryService.SaveChangesAsync();


            Category = category;

            successMessage = "Category updated successfully";
            Response.Redirect("/Admin/Categories/ListCategory");
        }
    }
}
