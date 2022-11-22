using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieLover.Models
{
    public class RegisterModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Confirm Email")]
        public string ConfirmEmail { get; set; }

        [Required]
        public string Password { get; set; }
        
        [Required]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}
