namespace CoreWebAppDemo.Models
{
    public class ProductRepo
    {
        private static List<Product> _products = new()
    {
        new Product { ProductId = 1, Name = "Laptop", Price = 50000, ImageUrl = "/images/monitor.jpg" },
        new Product { ProductId = 2, Name = "Mouse", Price = 500, ImageUrl = "/images/mouse.jpg" },
        new Product { ProductId = 3, Name = "Keyboard", Price = 1500, ImageUrl = "/images/keyboard.jpg" },
        new Product { ProductId = 6, Name = "USB Cable", Price = 300, ImageUrl = "/images/usb.jpg" },
        new Product { ProductId = 7, Name = "Webcam", Price = 3500, ImageUrl = "/images/webcam.jpg" },
        new Product { ProductId = 9, Name = "Gaming Chair", Price = 15000, ImageUrl = "/images/chair.jpg" },
        new Product { ProductId = 10, Name = "Bluetooth Speaker", Price = 2800, ImageUrl = "/images/bluetoothspeaker.jpg" }
    };

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
