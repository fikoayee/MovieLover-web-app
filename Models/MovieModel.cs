using MovieLover.Data.Base;
using MovieLover.Data.Static;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLover.Models
{
    public class MovieModel : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Description { get; set; }
        //[RegularExpression(@"^[0-9]{1,2}([,.][0-9]{1,2})?$", ErrorMessage = "The value is not valid")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }
        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Release date is required")]
        public DateTime ReleaseDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        [Required(ErrorMessage = "Image is required")]
        public string? ImageURL { get; set; }
        [Display(Name = "Hours")]
        public int LengthHours { get; set; }
        [Display(Name = "Minutes")]
        public int LengthMinutes { get; set; }

        //relationships
        public List<ActorMovieModel>? ActorsMovies { get; set; }

        //producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public ProducerModel? Producer { get; set; }
    }
}
