using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            if(name == "")
            {
                Console.WriteLine("Nothing here!");
            }
            else 
            { 
                Console.WriteLine("Hello, " + name + "!");
            }

        }
    }
}
