using System.ComponentModel.DataAnnotations;

namespace MovieLover.Models
{
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }
        public string Email { get;set; }
        public string UserId { get; set; }

        public List<OrderItemModel> OrderItems { get; set; }

    }
}
