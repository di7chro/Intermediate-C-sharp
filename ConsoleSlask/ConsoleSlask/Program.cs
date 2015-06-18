using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSlask
{
    class Program
    {
        public struct Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int YearOfBirth;

            // En låtsas-konstruktor för en Struct
            public Person(string firstName, string lastName, int yearOfBirth)
                : this()
            {
                FirstName = firstName;
                LastName = lastName;
                YearOfBirth = yearOfBirth;
            }
        }

        static void WaitForInput()
        {
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }

        private static void PrintPerson(Person p)
        {
            Console.WriteLine("FirstName: " + p.FirstName);
            Console.WriteLine("LastName: " + p.LastName);
            Console.WriteLine("YearOfBirth: " + p.YearOfBirth);
            WaitForInput();
        }

        static void Main()
        {
            Console.WriteLine("Hello World!");
            Person p = new Person(firstName: "Christian", lastName: "Ohlsson", yearOfBirth: 1973);
            PrintPerson(p);
        }
    }

}
