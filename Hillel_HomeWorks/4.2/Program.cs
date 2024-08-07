using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input first number");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second number");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the operation (+, -, *, /)");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("It's forbidden to devide by zero");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Result: {(num1 / num2):F2}");
                        break;
                    }
                default:
                    Console.WriteLine("Invalid symbol inputed");
                    break;

            }
        }
    }
}
