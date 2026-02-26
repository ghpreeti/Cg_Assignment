using CoreWebAppDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAppDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepo _productRepo;
        private readonly CartService _cartService;

        public ProductController(ProductRepo productRepo, CartService cartService)
        {
            _productRepo = productRepo;
            _cartService = cartService;
        }

        [Route("")]
        [Route("Cosmetics")]
        [Route("Product/BeautyProduct")]
        public IActionResult Index1()
        {
            var products = _productRepo.GetAllProducts();
            return View(products);
        }
        public IActionResult AddToCart(int id)
        {
            var product = _productRepo.GetProductById(id);

            if (product != null)
            {
                _cartService.AddToCart(product);
            }

            return RedirectToAction("Index1");
        }
        //public IActionResult Index3()
        //{
        //    return View(productRepo.GetAllCosmeticProduct());
        //}
    }
}
