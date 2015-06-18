using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise9B
{
    static class Program
    {
        static void Main(string[] args)
        {
            var integerList = new List<int> {6, 2, 7, 4, 3, 9, 8, 5, 1};
            Console.WriteLine("\nUn-ordered List");
            PrintList(integerList);

            var orderedList = integerList.OrderMyList();
            Console.WriteLine("\n\nSorted List");
            PrintList(orderedList);

            WaitForInput();
        }

        private static void PrintList(List<int> result)
        {
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }



        public static List<int> OrderMyList(this List<int> input)
        {
            var newList = new List<int>();

            while (input.Count > 0)
            {
                int min = input.Min();
                newList.Add(min);
                input.RemoveAt(input.IndexOf(input.Min()));
            }
              
            return newList;
        } 
        private static void WaitForInput()
        {
            Console.WriteLine("\nEnter a key...");
            Console.ReadLine();
        }

    }
}
