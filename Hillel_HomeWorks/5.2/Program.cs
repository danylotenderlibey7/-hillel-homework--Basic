using System;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            try
            {
                string str_number = Console.ReadLine();
                double number = Convert.ToDouble(str_number);

                Console.WriteLine($"Your number: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Inputed an invalid number.");
            }
        }
    }
}
