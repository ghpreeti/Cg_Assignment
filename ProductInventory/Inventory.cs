using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInventory
{
    internal class Inventory : IInventory
    {
        private List<IProduct> _products = new List<IProduct>();
        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            if (_products.Contains(product))
            {
                _products.Remove(product);
            }
        }

        public int CalculateTotalValue()
        {
            int total = 0;
            foreach (var p in _products)
            {
                total += p.Price;
            }
            return total;
        }

        public List<IProduct> GetProductsByCategory(string category)
        {
            List<IProduct> list = new List<IProduct>();
            if (category != null) {
                foreach (var p in _products)
                {
                    if (p.Category.Equals(category))
                    {
                        list.Add(p);
                    }
                }
            }

            return list;

        }

        public List<(string, int)> GetProductsByCategoryWithCount()
        {
            List<(string,int)> list = new List<(string, int)>();
            foreach (var p in _products)
            {
                bool found = false;

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Item1 == p.Category)
                    {
                        list[i] = (list[i].Item1, list[i].Item2 + 1);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    list.Add((p.Category, 1));
                }
            }

            return list;

        }

        public List<IProduct> SearchProductsByName(string name)
        {
            List<IProduct> list = new List<IProduct>();
            if (name != null)
            {
                foreach (var p in _products)
                {
                    if (p.Name.Equals(name))
                    {
                        list.Add(p);
                    }
                }
            }
            return list;
        }


        public List<(string, List<IProduct>)> GetAllProductsByCategory()
        {
            List<(string, List<IProduct>)> result = new List<(string, List<IProduct>)>();

            foreach (var p in _products)
            {
                bool found = false;

                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i].Item1 == p.Category)
                    {
                        result[i].Item2.Add(p);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    List<IProduct> newList = new List<IProduct>();
                    newList.Add(p);
                    result.Add((p.Category, newList));
                }
            }

            return result;

        }






    }
}
