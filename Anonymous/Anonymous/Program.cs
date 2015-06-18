using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            var anonymous = new
            {
                UserName = "MrRogers",
                RegisterDate = DateTime.Now
            };
            Console.WriteLine(anonymous.UserName);

            WaitForInput();
        }
        public static void WaitForInput()
        {
            Console.WriteLine("Press a key...");
            Console.ReadLine();
        }
    }
}
