using System.ComponentModel.DataAnnotations;

namespace MovieLover.Models
{
    public class ShoppingCartItemModel
    {
        [Key]
        public int Id { get; set; }
        public MovieModel Movie { get; set; }
        public string ShoppingCartId { get; set; }  
    }
}
