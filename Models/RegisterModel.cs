using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieLover.Models
{
    public class RegisterModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z]{1,20}$", ErrorMessage = "First name must contain only letters. Please try again.")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z]{1,20}$", ErrorMessage = "Last name must contain only letters. Please try again.")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Please enter your username")]
        [RegularExpression(@"^[a-zA-Z0-9]{3,32}$", ErrorMessage = "Username must contain only letters and numbers (min 3 max 32 characters). Please try again.")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Please enter your email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please confirm your email")]
        [Display(Name = "Confirm Email")]
        [Compare("Email")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number and one special character (min 8 characters). Please try again.")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Please confirm your password")]
        [Display(Name="Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
