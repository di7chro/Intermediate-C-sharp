using System.Collections.Generic;

namespace StoreData
{
    public interface IShoppingCart
    {
        /// <summary>
        /// This method adds a product to the shopping cart
        /// </summary>
        /// <param name="p">The product to add</param>
        void AddProduct(Product p);

        /// <summary>
        /// Remove product by number
        /// </summary>
        /// <param name="index">The index of the product to remove</param>
        void RemoveProductByNumber(int index);

        /// <summary>
        /// Clears the entire shopping cart
        /// </summary>
        void Clear();

        /// <summary>
        /// Calculate the sum of the cost of all products
        /// </summary>
        /// <returns></returns>
        decimal TotalSum();

        /// <summary>
        /// Returns true if cart is empty, otherwise false
        /// </summary>
        bool CartIsEmpty();

        List<Product> Products { get; }
    }
}