using System;

namespace _10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a sentence:");
            string str = Console.ReadLine();

            string str_new = str.Replace(" ", "");
            Console.WriteLine(str_new);
        }
    }
}
