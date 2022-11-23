using System.ComponentModel.DataAnnotations;

namespace MovieLover.Models
{
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Wrong username or/and password")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Wrong username or/and password")]
        public string Password { get; set; }
        
    }
}
