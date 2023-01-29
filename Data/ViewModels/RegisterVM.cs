using System.ComponentModel.DataAnnotations;

namespace MovieLover.Data.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [Display(Name = "Full name")]
        [RegularExpression(@"^[A-Za-z  ,]+$", ErrorMessage = "This field must contain only letters. Please try again.")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Email address")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email address is required")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$", ErrorMessage = "Password must contain an uppercase character, lowercase character, a digit, and a special character. Passwords must be at least six characters long.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password do not match")]
        public string ConfirmPassword { get; set; } 
        


    }
}
