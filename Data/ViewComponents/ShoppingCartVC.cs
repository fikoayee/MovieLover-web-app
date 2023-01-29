using Microsoft.AspNetCore.Mvc;

namespace MovieLover.Data.ViewComponents
{
    public class ShoppingCartVC : ViewComponent
    {
        private readonly ShoppingCart.ShoppingCart _shoppingCart;

        public ShoppingCartVC(ShoppingCart.ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            return View(items.Count());
        }



    }
}
