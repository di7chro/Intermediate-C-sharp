using System;
using System.Collections.Generic;
using StoreData;

namespace Exercise1
{
    public class ShoppingDemo
    {
        private IShoppingCart cart;
        private IAccount account;
        private List<Product> store;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="cart"></param>
        /// <param name="account"></param>
        public ShoppingDemo(IShoppingCart cart, IAccount account)
        {
            PopulateStore();
            this.cart = cart;
            this.account = account;
        }

        /// <summary>
        /// Populate the store with a bunch of book titles
        /// </summary>
        private void PopulateStore()
        {
            store = new List<Product>
                        {
                            new Product {Name = "Professional C# 4 and .NET 4", Price = 354},
                            new Product {Name = "Beginning ASP.NET E-Commerce in C#", Price = 260},
                            new Product {Name = "Objektorienterad analys och design", Price = 418},
                            new Product {Name = "Improving Software Organizations", Price = 486},
                            new Product {Name = "Operating System Concepts", Price = 514},
                            new Product {Name = "Compilers: Principles, techniques and Tools", Price = 1265},
                            new Product {Name = "Pro Git", Price = 221},
                            new Product {Name = "Design Patterns", Price = 315}
                        };
        }

        /// <summary>
        /// Run the demo application
        /// </summary>
        public void Run()
        {
            var running = true;

            while (running)
            {
                PrintMainMenu();
                
                var input = Console.ReadLine();

                if (input == "6")
                    running = false;
                else
                    MakeChoice(input);
            }
        }

        /// <summary>
        /// Make a choice from the main menu
        /// </summary>
        /// <param name="input"></param>
        private void MakeChoice(string input)
        {
            switch (input)
            {
                case "1":
                    AddProductDialog();
                    break;

                case "2":
                    RemoveProductDialog();
                    break;

                case "3":
                    EmptyShoppingCartDialog();
                    break;

                case "4":
                    ListProductsDialog();
                    break;

                case "5":
                    PaymentDialog();
                    break;
            }
        }

        /// <summary>
        /// Print a list of all products
        /// </summary>
        private void ListProductsDialog()
        {
            Console.Clear();
            Console.WriteLine("List of all products in shopping cart:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            var listOfProducts = cart.Products;

            if (listOfProducts.Count == 0)
                Console.WriteLine("-- The shopping cart is empty --");

            for (int i=0; i<listOfProducts.Count; i++)
            {
                Console.WriteLine("{0}) {1}.PRICE: {2} SEK", i+1, listOfProducts[i].Name, listOfProducts[i].Price);
            }

            Console.WriteLine();
            WaitForInput();
        }

        /// <summary>
        /// Shown when it's time to pay
        /// </summary>
        private void PaymentDialog()
        {
            Console.Clear();
            
            if (cart.CartIsEmpty())
            {
                Console.WriteLine("\n -- The cart is empty, you have nothing to pay yet. --\n");
                WaitForInput();
                return;
            }

            var sum = cart.TotalSum();

            Console.WriteLine("TOTAL       : " + sum);
            Console.WriteLine("YOUR BALANCE: " + account.Balance);
            Console.WriteLine();

            if (sum > account.Balance)
            {
                Console.WriteLine("We're sorry, but you don't have enough funds on your account");
            }
            else
            {
                Console.Write("Do you want to pay? (y/n) ");
                var input = Console.ReadLine();

                if (input.ToLower() == "n")
                    return;

                Console.WriteLine("Thank you! Your order has been processed!");
                account.Remove(sum);
                cart.Clear();
            }

            WaitForInput();
        }

        /// <summary>
        /// Clear the shopping cart
        /// </summary>
        private void EmptyShoppingCartDialog()
        {
            cart.Clear();

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" -- Cleared shopping cart --");
            Console.WriteLine();

            WaitForInput();
        }

        /// <summary>
        /// Shown when removing a product
        /// </summary>
        private void RemoveProductDialog()
        {
            Console.Clear();
            Console.WriteLine("List of all products in shopping cart:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            var listOfProducts = cart.Products;

            if (listOfProducts.Count == 0)
            {
                Console.WriteLine("-- The shopping cart is empty --\n");
                WaitForInput();
                return;
            }

            for (int i = 0; i < listOfProducts.Count; i++)
            {
                Console.WriteLine("{0}) {1}.PRICE: {2} SEK", i + 1, listOfProducts[i].Name, listOfProducts[i].Price);
            }

            Console.WriteLine();
            Console.Write("Select an item to REMOVE: ");

            var input = Console.ReadLine();
            int coercedInput;

            if (!int.TryParse(input, out coercedInput))
            {
                Console.WriteLine("Must enter a number!");
            }
            else
            {
                var products = cart.Products;

                if (coercedInput > products.Count || coercedInput <= 0)
                    Console.WriteLine("Not a valid number!");
                else
                {
                    cart.RemoveProductByNumber(coercedInput-1);
                    Console.WriteLine("Removed item from cart!");
                }
            }

            Console.WriteLine();
            WaitForInput();
        }

        /// <summary>
        /// The dialogue shown when adding a product to the cart
        /// </summary>
        private void AddProductDialog()
        {
            Console.Clear();
            Console.WriteLine("Products in store");
            Console.WriteLine("-----------------");
            Console.WriteLine();

            for (int i = 0; i < store.Count; i++)
            {
                Console.WriteLine("{0}) {1}. PRICE: {2} SEK", i+1, store[i].Name, store[i].Price);
            }

            Console.WriteLine();
            Console.Write("Enter a product number: ");
            
            var input = Console.ReadLine();
            int coercedInput;
            
            if (!int.TryParse(input, out coercedInput))
            {
                Console.WriteLine("Must enter a number!");
            }
            else
            {
                if (coercedInput > store.Count || coercedInput <= 0)
                    Console.WriteLine("Not a valid number!");
                else
                {
                    cart.AddProduct(store[coercedInput-1]);
                    Console.WriteLine("Added Item!");
                }
            }
            
            WaitForInput();
        }

        /// <summary>
        /// Shows the main menu
        /// </summary>
        public void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("---------");
            Console.WriteLine("YOUR BALANCE: " + account.Balance);
            Console.WriteLine("TOTAL: " + cart.TotalSum());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Add product to shopping cart");
            Console.WriteLine("2. Remove product from shopping cart");
            Console.WriteLine("3. Empty shopping cart");
            Console.WriteLine("4. List products in shopping cart");
            Console.WriteLine("5. Pay");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Make a choice: ");
        }

        /// <summary>
        /// Just a method to wait for the user to press enter
        /// </summary>
        private void WaitForInput()
        {
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}