using E_Books.Data;
using E_Books.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Books.Data.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly AppDbContext _ctx;
        public OrdersService(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole)
        {
            var orders = await _ctx.Orders.Include(n => n.Items).ThenInclude(n => n.Book).ToListAsync();
            return orders;
        }

        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = userId,
                Email = userEmailAddress
            };

            await _ctx.Orders.AddAsync(order);
            await _ctx.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderitem = new OrderItem()
                {
                    Amount = item.Amount,
                    BookId = item.Book.Id,
                    OrderId = order.Id,
                    Price = item.Book.Price
                };
                await _ctx.OrderItems.AddAsync(orderitem);
            }
            await _ctx.SaveChangesAsync();
        }
    }
}
