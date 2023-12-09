using E_Books.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Books.Data.Cart
{
    public class ShoppingCart
    {
        public AppDbContext _ctx { get; set; }
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) {ShoppingCartId = cartId};
        }

        public void AddItemToCard(Book book)
        {
            var shoppingCartItem = _ctx.ShoppingCartItems.FirstOrDefault(n => n.Book.Id == book.Id && n.ShoppingCartId == ShoppingCartId);
            
            if(shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem() 
                {
                    ShoppingCartId = ShoppingCartId,
                    Book = book,
                    Amount = 1
                };

                _ctx.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _ctx.SaveChanges();
        }

        public void RemoveItemFromCart(Book book)
        {
            var shoppingCartItem = _ctx.ShoppingCartItems.FirstOrDefault(n => n.Book.Id == book.Id && n.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem != null)
            {
                if(shoppingCartItem.Amount > 1) 
                {
                    shoppingCartItem.Amount --;
                } else
                {
                    _ctx.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _ctx.SaveChanges();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _ctx.ShoppingCartItems.Where
                (n => n.ShoppingCartId == ShoppingCartId).Include(n => n.Book).ToList());
        }

        public decimal GetShoppingCartTotal() => _ctx.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId)
            .Select(n => n.Book.Price * n.Amount).Sum();

        public async Task ClearShoppingCartAsync()
        {
            var items = await _ctx.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId).ToListAsync();
            _ctx.ShoppingCartItems.RemoveRange(items);
            await _ctx.SaveChangesAsync();
        }
    }
}
