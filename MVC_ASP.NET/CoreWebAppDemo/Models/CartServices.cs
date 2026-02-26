namespace CoreWebAppDemo.Models
{
    public class CartService
    {
        private readonly List<CartItem> _cartItems = new();

        public void AddToCart(Product product)
        {
            var existing = _cartItems
                .FirstOrDefault(x => x.Product.ProductId == product.ProductId);

            if (existing != null)
                existing.Quantity++;
            else
                _cartItems.Add(new CartItem
                {
                    Product = product,
                    Quantity = 1
                });
        }

        public List<CartItem> GetCart()
        {
            return _cartItems;
        }

        public int GetCartCount()
        {
            return _cartItems.Sum(x => x.Quantity);
        }
    }
}
