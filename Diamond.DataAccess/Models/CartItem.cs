using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Models
{
    public class CartItem
    {
        [Key, ForeignKey(nameof(User))]
        public int CartItemId { get; set; }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public ICollection<Product> Products { get; set; }
        public User User { get; set; }
    }
}
