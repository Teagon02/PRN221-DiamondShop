using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        //FK
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }

    }
}
