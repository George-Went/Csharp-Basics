using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enter Numbers
            Console.Write("Enter Number 1 : ");
            string val1 = Console.ReadLine();

            if(val1 == "")
            {
                Console.WriteLine("Nothing here!");
            }

            Console.Write("Enter Number 2 : ");
            string val2 = Console.ReadLine();

            if (val2 == "")
            {
                Console.WriteLine("Nothing here!");
            }

            Console.WriteLine("Enter an operator [add/sub/div/mul] : ");
            string operation = Console.ReadLine();

            // Work out operator
            if (operation == "add")
            {
                Console.WriteLine("Add");
            }
            if (operation == "sub")
            {
                Console.WriteLine("Sub");
            }
            if (operation == "div")
            {
                Console.WriteLine("div");
            }
            if (operation == "mul")
            {
                Console.WriteLine("mul");
            }

        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Subtract(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Multiply(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Divide(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
