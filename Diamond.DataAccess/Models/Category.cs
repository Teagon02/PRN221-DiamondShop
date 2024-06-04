using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required, MaxLength(50)]
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
