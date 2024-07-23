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
                LessThanOneHour = CalculateProgress(UserCount, ProductCount, CategoryCount, 1),
                OneToThreeHours = CalculateProgress(UserCount, ProductCount, CategoryCount, 3),
                MoreThanThreeHours = CalculateProgress(UserCount, ProductCount, CategoryCount, 6),
                MoreThanSixHours = CalculateProgress(UserCount, ProductCount, CategoryCount, 24)
            };
        }

        private int CalculateProgress(int userCount, int productCount, int categoryCount, int hours)
        {
            // ?ây là logic ví d? ?? tính toán ti?n ?? công vi?c d?a trên s? l??ng ng??i dùng m?i, s?n ph?m m?i và danh m?c m?i
            int totalTasks = userCount + productCount + categoryCount;

            if (hours <= 1)
                return (int)((double)userCount / totalTasks * 100);
            else if (hours <= 3)
                return (int)((double)productCount / totalTasks * 100);
            else if (hours <= 6)
                return (int)((double)categoryCount / totalTasks * 100);
            else
                return (int)((double)(userCount + productCount + categoryCount) / totalTasks * 100);
        }
    }
}
