using MovieLover.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using MovieLover.Data.Static;

namespace MovieLover.Data.ViewModels
{
    public class NewMovieVM
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Description { get; set; }
        [RegularExpression(@"^[0-9]{1,2}([.][0-9]{1,2})?$", ErrorMessage = "The value is not valid")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }
        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Release date is required")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Category")]
        public MovieCategory MovieCategory { get; set; }
        [Required(ErrorMessage = "Image is required")]
        public string? ImageURL { get; set; }
        [Display(Name = "Hour(s)")]
        [RegularExpression(@"^[0-9]{1,2}?$", ErrorMessage = "The value is not valid")]
        public int LengthHours { get; set; }
        [Display(Name = "Minute(s)")]
        [RegularExpression(@"^([0-5]?[0-9]|59)$", ErrorMessage = "The value is not valid")]
        public int LengthMinutes { get; set; }


        //relationships
        [Display(Name="Actor(s)")]
        public List<int>? ActorsId { get; set; }
        [Display(Name = "Producer")]
        public int ProducerId { get; set; }
    }
}
