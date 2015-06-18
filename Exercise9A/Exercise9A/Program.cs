using System;

namespace Exercise9A
{
    public delegate double CalcDelegate(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            var myCalculator = new Calculator();
            //myCalculator.CalcLogic = (a, b) => Math.Pow(a, b);
            //myCalculator.CalcLogic = (a, b) => a + b;
            myCalculator.CalcLogic = (a, b) => a - b;
            myCalculator.PrintCalculation(3, 4);


            WaitForInput();
        }

        private static void WaitForInput()
        {
            Console.WriteLine("\nEnter a key...");
            Console.ReadLine();
        }

    }
}
