using MovieLover.Data.ShoppingCart;

namespace MovieLover.Data.ViewModels
{
    public class ShoppingCartVM
    {
        public ShoppingCart.ShoppingCart ShoppingCart { get; set; }
        public double PriceTotal { get; set; }
    }
}
