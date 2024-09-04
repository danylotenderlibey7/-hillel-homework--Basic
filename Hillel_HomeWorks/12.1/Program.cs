using System;

namespace _12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input number: ");
                int i = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    throw new ArgumentException("Index 0 is not valid as there is no corresponding Fibonacci number");
                }
                Console.WriteLine($"Your number: {GetFibonacciNumber(i)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static int GetFibonacciNumber(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return GetFibonacciNumber(n - 1) + GetFibonacciNumber(n - 2);
        }
    }
}
