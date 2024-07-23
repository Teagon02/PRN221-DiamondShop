using System.ComponentModel.DataAnnotations;

namespace Diamond.DataAccess.DTO
{
    public class RegisterUserDto
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }


        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
