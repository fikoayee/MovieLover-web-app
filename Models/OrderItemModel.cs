using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieLover.Models
{
    public class OrderItemModel
    {
        [Key]
        public int Id { get; set; }
        public double Price { get; set; }
        public int MovieId { get; set; }

        [ForeignKey("MovieId")]
        public MovieModel Movie { get; set; }

        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public OrderModel Order { get; set; }
    }
}
