using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Metrics;

namespace Diamond.RazorPage.Pages.Views.Dashboard
{
    public class DashBoardModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IUserService _userService;
        public readonly ICategoryService _categoryService;

        public DashBoardModel(IProductService productService, IUserService userService, ICategoryService categoryService)
        {
            _productService = productService;
            _userService = userService;
            _categoryService=categoryService;
        }

        public IList<ProductPriceDTO> ProductPrices { get; set; }
        public int UserCount { get; set; }
        public int ProductCount { get; set; }   
        public int CategoryCount { get; set; }
        public ProgressModel Progress { get; set; }
        public class ProgressModel
        {
            public int LessThanOneHour { get; set; }
            public int OneToThreeHours { get; set; }
            public int MoreThanThreeHours { get; set; }
            public int MoreThanSixHours { get; set; }
        }

        public async Task OnGetAsync()
        {
            ProductPrices = await _productService.Dashboardlist();
            UserCount = await _userService.GetUserCountAsync(); 
            ProductCount = await _productService.GetProductCountAsync();
            CategoryCount = await _categoryService.GetCategoryCountAsync();
            Progress = new ProgressModel
            {
                LessThanOneHour = CalculateProgress(UserCount),
                OneToThreeHours = CalculateProgress(ProductCount),
                MoreThanThreeHours = CalculateProgress(CategoryCount),
                MoreThanSixHours = CalculateProgress(UserCount + ProductCount + CategoryCount)
            };
        }

        private int CalculateProgress(int count)
        {
          
            if (count < 100)
                return 20;
            else if (count < 200)
                return 40;
            else if (count < 300)
                return 60;
            else if (count < 400)
                return 80;
            else
                return 100;
        }
    }
}
