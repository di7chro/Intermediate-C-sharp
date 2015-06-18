using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    static class WeightExtensions
    {
        public static Weight ConvertToWeight(this double input, WeightUnit unit)
        {
            var w = new Weight();

            w.SetWeight(unit, input);

            return w;
        }

        public static Weight ConvertToWeight(this string input, WeightUnit unit)
        {
            var w = new Weight();
            
            w.SetWeight(unit, Double.Parse(input));

            return w;
        }

        public static void PrintMe(this Weight input, WeightUnit unit)
        {
            Console.WriteLine("This objects weights " + input.GetWeight(WeightUnit.Kilogram) + " " + unit);
        }
    }
}
