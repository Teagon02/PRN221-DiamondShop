using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.IRepositories;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Diamond.RazorPage.Pages.Views.Dashboard
{
    public class DashBoardModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;
        private readonly IOrderRepository _orderService;

        public DashBoardModel(IProductService productService, ICategoryService categoryService, IUserService userService , IOrderRepository orderRepository)
        {
            _productService = productService;
            _categoryService = categoryService;
            _userService = userService;
            _orderService = orderRepository;
        }

        public IList<ProductPriceDTO> ProductPrices { get; set; }
        public int ProductCount { get; set; }
        public int CategoryCount { get; set; }
        public int UserCount { get; set; }
        public int OrderCount { get; set; }
        public IList<OrderDTO> OrderList { get; set; }

        public async Task OnGetAsync()
        {
            ProductPrices = await _productService.Dashboardlist();
            ProductCount = await _productService.GetProductCount();
            CategoryCount = await _categoryService.GetCategoryCount();
            UserCount = await _userService.GetUserCount();
            OrderCount = await _orderService.GetOrderCount();
            OrderList = await _orderService.GetOrderList();
        }
    }
}
