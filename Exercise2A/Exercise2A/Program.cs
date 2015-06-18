using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise2A
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> intStack = new CustomStack<int>();
            CustomStack<string> stringStack = new CustomStack<string>();

            /* ------ INT-STACK --------------- */
            intStack.Push(14);
            intStack.Push(23);
            intStack.Push(34);
            intStack.Push(46);
            Console.WriteLine(intStack.Peek());

            intStack.Pop();
            Console.WriteLine(intStack.Peek());

            /* ------ STRING-STACK --------------- */
            stringStack.Push("Anna");
            stringStack.Push("Bertil");
            stringStack.Push("Ceasar");
            Console.WriteLine(stringStack.Peek());

            stringStack.Pop();
            Console.WriteLine(stringStack.Peek());


            WaitForInput();
        }
        static void WaitForInput()
        {
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
