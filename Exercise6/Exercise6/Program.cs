using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var myScienceStack = new CustomStack<string>();

            myScienceStack.Push("Carl Sagan");
            myScienceStack.Push("Albert Einstein");
            myScienceStack.Push("Stephen Hawking");
            myScienceStack.Push("Neil deGrasse Tyson");
            myScienceStack.Push("Wolfgang Pauli");
            myScienceStack.Push("Edsger Dijkstra");
            myScienceStack.Push("Bjarne Stroustrup");
            myScienceStack.Push("Linus Torvalds");
            */

            var myScienceStack = new CustomStack<string> ()
            {
                "Carl Sagan",
                "Albert Einstein",
                "Stephen Hawking",
                "Neil deGrasse Tyson",
                "Wolfgang Pauli",
                "Edsger Dijkstra",
                "Bjarne Stroustrup",
                "Linus Torvalds"
            };

            show(myScienceStack);
            WaitForInput();
        }

        private static void show(CustomStack<string> myScienceStack)
        {
            foreach (var person in myScienceStack)
            {
                Console.WriteLine("Person: " + person);
            }
            ;
        }


        static void WaitForInput()
        {
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
