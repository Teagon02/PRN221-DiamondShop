using Diamond.BusinessLogic.IServices;
using Diamond.DataAccess.Data;
using Diamond.DataAccess.DTO;
using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diamond.RazorPage.Pages.Admin.Dashboard
{
    public class DashBoardModel : PageModel
    {
       
        private readonly IProductService _productService;

        public DashBoardModel( IProductService productService)
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
