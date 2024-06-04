using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Models
{
    public class Product
    {

        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string MainStoneSize { get; set; }
        [Required]
        public string SideStoneType { get; set; }
        [Required]
        public int SideStoneQuantity { get; set; }
        [Required]
        public double SideStoneWeight { get; set; }
        [Required]
        public string GoldType { get; set; }
        [Required]
        public string GoldKarat { get; set; }
        [Required]
        public double GoldWeight { get; set; }
        public bool Status { get; set; }
        public double Price { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        //FK 
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        // Navigation
        public ICollection<Image> Images { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
