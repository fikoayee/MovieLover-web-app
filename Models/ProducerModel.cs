using MovieLover.Data.Base;
using MovieLover.Data.Services;
using System.ComponentModel.DataAnnotations;

namespace MovieLover.Models
{
    public class ProducerModel : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [RegularExpression(@"^[A-Za-z  ,]+$", ErrorMessage = "Full name must contain only letters. Please try again.")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        public string Biography { get; set; }
        [Display(Name = "Birt Date")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Death Date")]
        public DateTime? DateOfDeath { get; set; }
        [RegularExpression(@"^[A-Za-z  ,]+$", ErrorMessage = "This field must contain only letters. Please try again.")]
        [Display(Name = "Birth City")]
        public string PlaceOfBirthCity { get; set; }
        [RegularExpression(@"^[A-Za-z  ,]+$", ErrorMessage = "This field must contain only letters. Please try again.")]
        [Display(Name = "Birh Country")]
        public string PlaceOfBirthCountry { get; set; }
        public string? ImageURL { get; set; }

        //relationships
        public List<MovieModel>? Movies { get; set; }
    }
}