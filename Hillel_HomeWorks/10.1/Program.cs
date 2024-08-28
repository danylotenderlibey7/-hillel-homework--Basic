using System;

namespace _10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your name and surname");
            string str = Convert.ToString(Console.ReadLine());
            char first_letter = str[0];
            char second_letter = ' ';
            for (int i = 0; i < str.Length; i++) 
            {
                if (str[i] == ' ') 
                {
                    second_letter = str[i + 1];
                    break;
                }
            }
            if (first_letter == second_letter) 
            {
                Console.WriteLine("Name and surname start with the same letter");
            }
            else
            {
                Console.WriteLine("Name and surname don't start with the same letter");
            }
        }
    }
}
