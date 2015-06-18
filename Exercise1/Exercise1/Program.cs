using System;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup a test account
            var account = new Account();
            account.Add(1500);

            // Create an empty shopping cart
            var cart = new ShoppingCart();

            // Run the demo
            var demo = new ShoppingDemo(cart, account);
            demo.Run();
        }
    }
}
