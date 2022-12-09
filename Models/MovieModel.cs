using MovieLover.Data;
using MovieLover.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLover.Models
{
    public class MovieModel : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //[RegularExpression(@"^[0-9]{1,2}([,.][0-9]{1,2})?$", ErrorMessage = "The value is not valid")]
        public double Price { get; set; }
        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Date is required")]
        public DateTime ReleaseDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public string ImageURL { get; set; }
        //public int MovieLength { get; set; }

        //relationships
        public List<ActorMovieModel>? ActorsMovies { get; set; }

        //producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public ProducerModel? Producer { get; set; }
    }
}
