using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Weight from a double of 2.5 Pounds
            double w = 2.5;
            var weightFromDouble = w.ConvertToWeight(WeightUnit.Pound);

            // Create a new Weight from a double of 2.5 Pounds
            var weightFromString = "15".ConvertToWeight(WeightUnit.Ounce);

            weightFromDouble.PrintMe(WeightUnit.Kilogram);
            weightFromString.PrintMe(WeightUnit.Pound);

            WaitForInput();
        }

        private static void WaitForInput()
        {
            Console.WriteLine("\nPress a key...");
            Console.ReadLine();
        }

    }
}
