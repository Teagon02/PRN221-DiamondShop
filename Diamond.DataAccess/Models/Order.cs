using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diamond.DataAccess.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; }
        public double Total { get; set; }
        public string Status { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string? Comments { get; set; }
        public string? TransactionId { get; set; }
        //
        //Navigation
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}
