using MovieLover.Models;

namespace MovieLover.Data.Services
{
    public interface IOrderService
    {
        Task StoreOrderAsync(List<ShoppingCartItemModel> items, string userId, string userEmail);
        Task<List<OrderModel>> GetOrdersByUserIdAsync(string userId);
        Task<List<OrderModel>> GetAllOrders();
    }
}
