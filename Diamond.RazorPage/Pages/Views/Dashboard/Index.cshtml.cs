using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diamond.RazorPage.Pages.Views.Dashboard
{
    public class DashBoardModel : PageModel
    {
        private readonly IProductService _productService;
        public DashBoardModel(IProductService productService)
        {
            _productService = productService;
        }
        public IList<ProductPriceDTO> ProductPrices { get; set; }

        public async Task OnGetAsync()
        {
            ProductPrices = await _productService.Dashboardlist();
        }
    }
}
