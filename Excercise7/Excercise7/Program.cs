using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise5;

namespace Excercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            // wFirst and wSecond are Weight-instances
            Weight wFirst = new Weight();
            Weight wSecond = new Weight();
            
            wFirst.SetWeight(WeightUnit.Kilogram, 50);
            wSecond.SetWeight(WeightUnit.Kilogram, 60);

            var first = wFirst.GetWeight(WeightUnit.Kilogram);
            
            wSecond.Add(wFirst);
            Console.WriteLine(wSecond.GetWeight(WeightUnit.Kilogram));

            wSecond.SetWeight(wFirst);
            Console.WriteLine(wSecond.GetWeight(WeightUnit.Kilogram));

            var wResult = wFirst + wSecond;
            Console.WriteLine(wResult.GetWeight(WeightUnit.Kilogram));
            
            WaitForInput();
        
        }

        private static void WaitForInput()
        {
            Console.WriteLine("\nPress enter...");
            Console.ReadLine();
        }

    }
}
