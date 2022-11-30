using MovieLover.Data;
using System.ComponentModel.DataAnnotations;

namespace MovieLover.Models
{
    public class MovieModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "The value is invalid.")]
        public double Price { get; set; }
        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Date is required")]
        public DateTime ReleaseDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public string ImageURL { get; set; }
    }
}
