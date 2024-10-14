using System;
using System.Collections.Generic;
using System.Linq;

namespace learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}");
            Console.WriteLine($"the length of the string is {name.Length}");

            
        }
    }
}
