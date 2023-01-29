using Microsoft.EntityFrameworkCore;
using MovieLover.Models;

namespace MovieLover.Data.Services
{
    public class OrderService : IOrderService
    {
        private readonly MovieLoverContext _context;
        public OrderService(MovieLoverContext context)
        {
            _context = context;
        }

        public async  Task<List<OrderModel>> GetAllOrders()
        {
            var orders = await _context.Orders.Include(n => n.OrderItems).ThenInclude(n => n.Movie).ToListAsync();
            return orders;
        }

        public async Task<List<OrderModel>> GetOrdersByUserIdAsync(string userId)
        {
            var orders = await  _context.Orders.Include(n => n.OrderItems).ThenInclude(n => n.Movie).Where(n => n.UserId == userId).ToListAsync();
            return orders;
        }

        public async Task StoreOrderAsync(List<ShoppingCartItemModel> items, string userId, string userEmail)
        {
            var order = new OrderModel()
            {
                UserId = userId,
                Email = userEmail,
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new OrderItemModel()
                {
                    MovieId = item.Movie.Id,
                    Price = item.Movie.Price,
                    OrderId = order.Id
                };
                await _context.OrderItems.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync();
        }
    }
}
