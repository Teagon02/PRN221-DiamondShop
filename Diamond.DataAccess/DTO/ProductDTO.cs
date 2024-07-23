using Diamond.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.DTO
{
    public class ProductDTO
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Main Stone Size is required.")]
        public string MainStoneSize { get; set; }

        [Required(ErrorMessage = "Side Stone Type is required.")]
        public string SideStoneType { get; set; }

        [Required(ErrorMessage = "Side Stone Quantity is required.")]
        public int SideStoneQuantity { get; set; }

        [Required(ErrorMessage = "Side Stone Weight is required.")]
        public double SideStoneWeight { get; set; }

        [Required(ErrorMessage = "Gold Type is required.")]
        public string GoldType { get; set; }

        [Required(ErrorMessage = "Gold Karat is required.")]
        public string GoldKarat { get; set; }

        [Required(ErrorMessage = "Gold Weight is required.")]
        public double GoldWeight { get; set; }
        public bool Status { get; set; }
        public double Price { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string PriceInVND { get; set; }
        public List<string> ImageUrls { get; set; }
        public ICollection<IFormFile> Images { get; set; } = new List<IFormFile>();
        public Category Category { get; set; }

    }
}
