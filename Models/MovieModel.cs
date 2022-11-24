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
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}
