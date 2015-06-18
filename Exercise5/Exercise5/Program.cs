using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        public static void Main()
        {
            var weight = new Weight();

            weight.SetWeight(WeightUnit.Kilogram, 2.0);
            weight.Add(WeightUnit.Pound, 1.0);
            weight.Add(WeightUnit.Gram, 450.0);
            weight.Add(WeightUnit.Ounce, 1234.0);

            Console.WriteLine("2 Kilo + 1 Pound + 450 Gram + 1234 Ounce is");
            Console.WriteLine("================================================\n");
            
            // This line prints 2.453592
            Console.WriteLine("In Kilogram\t" + weight.GetWeight(WeightUnit.Kilogram));

            // This line prints 5.40924
            Console.WriteLine("In Pounds\t" + weight.GetWeight(WeightUnit.Pound));

            // This line prints 
            Console.WriteLine("In Grams\t" + weight.GetWeight(WeightUnit.Gram));

            // This line prints 
            Console.WriteLine("In Ounces\t" + weight.GetWeight(WeightUnit.Ounce));

            WaitForInput();

            // Dictionary<WeightUnit, double> myDictionary;
        }

        private static void WaitForInput()
        {
            Console.WriteLine("\nPress enter...");
            Console.ReadLine();
        }
    }
}
