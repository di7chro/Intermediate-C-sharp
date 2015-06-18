using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise4
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
                         select a;

            foreach (var item in result)
            {
                Console.WriteLine(item.Description);
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
