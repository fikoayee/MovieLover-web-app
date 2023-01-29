using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieLover.Data.Services;
using MovieLover.Data.ShoppingCart;
using MovieLover.Data.Static;
using MovieLover.Data.ViewModels;
using System.Security.Claims;

namespace MovieLover.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrderService _orderService;
        public OrderController(IMovieService movieService, ShoppingCart shoppingCart, IOrderService orderService)
        {
            _movieService = movieService;
            _shoppingCart = shoppingCart;
            _orderService = orderService;   
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var shoppingCart = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                PriceTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCart);
        }

        public async Task<RedirectToActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _movieService.GetMovieByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<RedirectToActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _movieService.GetMovieByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userEmail = User.FindFirstValue(ClaimTypes.Email);

            if (items.Count == 0)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                await _orderService.StoreOrderAsync(items, userId, userEmail);
                await _shoppingCart.ClearShoppingCartAsync();
                return View("OrderCompleted");
            }

        }

        public async Task<IActionResult> OrderList(string userId)
        {
            userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var orders = await _orderService.GetOrdersByUserIdAsync(userId);
            return View(orders);
        }
       
        [Authorize(Roles = UserRoles.Admin)]
        public async Task<IActionResult> OrderListAll()
        {

            var orders = await _orderService.GetAllOrders();
            return View(orders);
        }


    }
}
