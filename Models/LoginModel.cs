using System.ComponentModel.DataAnnotations;

namespace MovieLover.Models
{
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter Your email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter Your password")]
        public string Password { get; set; }
        
    }
}
