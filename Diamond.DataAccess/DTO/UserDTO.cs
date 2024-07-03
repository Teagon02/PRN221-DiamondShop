using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Diamond.DataAccess.DTO
{
    public  class UserDTO
    {
        [Required, MaxLength(100)]
        public string Email { get; set; } = "";

        [Required, MaxLength(100)]
        public string Name { get; set; } = "";

        [Required, MaxLength(100)]
        public string Password { get; set; } = "";
        [Required]
        public int Phone { get; set; }
        [Required, MaxLength(255)]
        public string Address { get; set; } = "";
       
        public IFormFile? Avatar { get; set; } 

        public bool Status { get; set; }
    }
}
