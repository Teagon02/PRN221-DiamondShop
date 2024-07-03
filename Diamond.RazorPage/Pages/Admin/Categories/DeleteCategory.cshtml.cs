using Diamond.BusinessLogic.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Diamond.RazorPage.Pages.Admin.Categories
{
    public class DeleteCategoryModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public DeleteCategoryModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("/Admin/Categories/ListCategory");
            }

            var category = _categoryService.Findid(id.Value);
            if (category == null)
            {
                return RedirectToPage("/Admin/Categories/ListCategory");
            }

            await _categoryService.DeleteAsync(category);
            await _categoryService.SaveChangesAsync();

            return RedirectToPage("/Admin/Categories/ListCategory");
        }
    }
}
