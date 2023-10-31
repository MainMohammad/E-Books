using E_Books.Data.Services;
using E_Books.Data.ViewModels;
using E_Books.Data.Cart;
using Microsoft.AspNetCore.Mvc;

namespace E_Books.Controllers
{
    public class OrdersController : Controller
    {

        private readonly IBooksServices _bookService;
        private readonly ShoppingCart _shoppingCart;

        public OrdersController(IBooksServices bookService, ShoppingCart shoppingCart)
        {
            _bookService = bookService;
            _shoppingCart = shoppingCart;
        }

        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(response);
        }

        public async Task<IActionResult> AddToShoppingCart(int Id)
        {
            var item = await _bookService.GetBookById(Id);

            if (item != null) 
            {
                _shoppingCart.AddItemToCard(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> RemoveFromShoppingCart(int Id)
        {
            var item = await _bookService.GetBookById(Id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }
    }
}
