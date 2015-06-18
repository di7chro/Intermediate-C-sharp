using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3
{
    class Program
    {
        static void Main()
        {
            ListLoader myLoader = new ListLoader();
            List<string> languages = new List<string>();

            languages = myLoader.LoadListFromFile("languages.txt");

            Console.Write("List languages containing: ");
            string searchFor = Console.ReadLine();

            var result = from a in languages
                         where a.ToLower().Contains(searchFor.ToLower())
                         select a;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            WaitForInput();
        }

        static void WaitForInput()
        {
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
