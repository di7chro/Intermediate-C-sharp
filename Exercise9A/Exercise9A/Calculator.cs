using System;

namespace Exercise9A
{
    class Calculator
    {
        public CalcDelegate CalcLogic { get; set; }

        public void PrintCalculation(double a, double b)
        {
            double result = CalcLogic(a, b);
            Console.WriteLine("Result: " + result); 
        }
    }
}
