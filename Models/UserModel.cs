using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace MovieLover.Models
{
    public class UserModel : IdentityUser
    {
        [Display(Name="Full name")]
        public string FullName { get; set; }
    }
}
