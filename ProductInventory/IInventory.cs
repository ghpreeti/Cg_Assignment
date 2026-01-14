namespace ProductInventory
{
    public interface IInventory
    {
        void AddProduct(IProduct product); 
        void RemoveProduct(IProduct product); 
        int CalculateTotalValue();
        List<IProduct> GetProductsByCategory(string category);
        List<IProduct> SearchProductsByName(string name);
        List<(string, int)> GetProductsByCategoryWithCount();
        List<(string, List<IProduct>)> GetAllProductsByCategory();


    }
}