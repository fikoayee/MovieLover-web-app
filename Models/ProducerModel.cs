using System.ComponentModel.DataAnnotations;

namespace MovieLover.Models
{
    public class ProducerModel
    {
        [Key]
        public int Id { get; set; }
        [RegularExpression(@"^[a-zA-Z]{1,40}$", ErrorMessage = "Full name must contain only letters. Please try again.")]
        public string FullName { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
        [RegularExpression(@"^[a-zA-Z]{1,20}$", ErrorMessage = "This field must contain only letters. Please try again.")]
        public string PlaceOfBirthCity { get; set; }
        [RegularExpression(@"^[a-zA-Z]{1,20}$", ErrorMessage = "This field must contain only letters. Please try again.")]
        public string PlaceOfBirthCountry { get; set; }
        public string ImageURL { get; set; }

        //relationships
        public List<MovieModel> Movies { get; set; }
    }
}