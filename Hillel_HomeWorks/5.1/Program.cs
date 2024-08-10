using System;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input first digit");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input second digit");
                double num2 = Convert.ToDouble(Console.ReadLine());
                
                if (num2 == 0)
                {
                    throw new DivideByZeroException(); 
                }

                double result = num1 / num2;
                Console.WriteLine($"Result: {(result):F2}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("It's forbidden to devide by zero");
            }
        }
    }
}
