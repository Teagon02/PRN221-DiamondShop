using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public bool Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        //FK
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }
    }
}
