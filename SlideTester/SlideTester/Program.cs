using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlideTester
{
    class Program
    {
        enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };

        static void Main(string[] args)
        {
            string Namnet = "Christian";
            string Name = null;
            Console.WriteLine(Name ?? "No name set");

            int x = 42;
            Console.WriteLine(x.Double());   

            WaitForInput();
        }

        static void WaitForInput()
        {
            Console.WriteLine("\nPress a key...");
            Console.ReadLine();
        }
    }

    static class Extension
    {
        public static int Double(this int input)
        {
            return input*2;
        }         
    }
}
