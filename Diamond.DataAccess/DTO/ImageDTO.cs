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
    public class ImageDTO
    {
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        [Required(ErrorMessage = "At least one image is required.")]
        public List<IFormFile> Images { get; set; }
        public string? Description { get; set; }
        public Product Product { get; set; }

    }
}
