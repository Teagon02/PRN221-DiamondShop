using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public double Total { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        //FK
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        //Navigation
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}
