using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MovieLover.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
