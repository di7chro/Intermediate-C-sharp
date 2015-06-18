using System.Collections.Generic;
using StoreData;

namespace Exercise1
{
    public class ShoppingCart : IShoppingCart
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public void RemoveProductByNumber(int index)
        {
            products.RemoveAt(index);
        }

        public void Clear()
        {
            products.Clear();
        }

        public decimal TotalSum()
        {
            decimal sum = 0;

            foreach (var product in Products)
            {
                sum += product.Price;
            }

            return sum;
        }

        public bool CartIsEmpty()
        {
            return (products.Count == 0);
        }

        public List<Product> Products
        {
            get { return products; }
        }
    }
}