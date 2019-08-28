using System;
using SophiAppConsole.Helpers;

namespace SophiAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal value1;
            decimal value2;
            decimal result = 0;
            string operation;
            Console.WriteLine("Enter first number: ");
            value1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            value2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Select operation: ");
            Console.WriteLine(" Addition(+)");
            Console.WriteLine(" Subtration(-)");
            Console.WriteLine(" Multiplication(*)");
            Console.WriteLine(" Division(/)");

            operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    result = MathHelper.Add(value1, value2);
                    result = value1 + value2;
                    break;
                case "-":
                    result=MathHelper.Subtract(value1, value2);
                    //result = value1 - value2;
                    break;
                case "*":
                    result = MathHelper.Multiplication(value1, value2);
                    // result = value1 * value2;
                    break;
                case "/":
                    if (value2 != 0)
                    {
                        result = MathHelper.Division(value1, value2);
                        //result = value1 / value2;

                    }
                    break;
            }
            if (value2 == 0 && operation == "/")
            {
                Console.WriteLine("Not a number");
            }
            else
            {
                Console.WriteLine("Result: {0}",result);
            }
        }

    }
}
