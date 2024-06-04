using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        //FK
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
