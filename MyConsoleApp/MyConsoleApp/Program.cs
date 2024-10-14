using System;
using MyLibrary;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(5, 3);
            Console.WriteLine("The result is: " + result);
        }
    }
}
