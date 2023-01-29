using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MovieLover.Data.Static
{
    public enum MovieCategory
    {
        Action = 1,
        Adventure,
        Comedy,
        Drama,
        Horror,
        Romance,
        [Display(Name = "Science Fiction")]
        Sciencefiction,
        Fantasy,
        Historical,
        Crime,
        Documentary,
        [Display(Name = "For Kids")]
        ForKids
    }
}
