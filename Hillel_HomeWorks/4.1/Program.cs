using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Input the digit from 1 to 7");
            int digit = Convert.ToInt32(Console.ReadLine());

            switch (digit)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid digit inputed");
                    break;
            }
        }
    }
}
