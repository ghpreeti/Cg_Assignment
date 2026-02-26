using CoreWebAppDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAppDemo.Controllers
{
    public class CartController : Controller
    {
        private readonly CartService _cartService;

        public CartController(CartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Index()
        {
            var cartItems = _cartService.GetCart();
            return View(cartItems);
        }
    }
}