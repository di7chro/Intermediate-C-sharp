using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    class Program
    {
        static void Main()
        {
            ListLoader myLoader = new ListLoader();
            List<LanguageData> languages = new List<LanguageData>();

            languages = myLoader.LoadListFromFile("languageData.txt");

            Console.Write("Minimum Year: ");
            string minimumYear = Console.ReadLine();
            Console.Write("Maximum Year: ");
            string maximumYTear = Console.ReadLine();

            var result = from a in languages
                         where a.Year > int.Parse(minimumYear) && a.Year < int.Parse(maximumYTear)
                         orderby a.Year
                         select new { a.Name, a.Year};

            Console.WriteLine("\nRESULTS");
            Console.WriteLine("======================");
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " (" + item.Year + ")");
            }
            WaitForInput();
        }

        static void WaitForInput()
        {
            Console.WriteLine("\nPress Enter...");
            Console.ReadLine();
        }
    }
}
