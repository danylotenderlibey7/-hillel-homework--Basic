using System;
using System.Text;

namespace _10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            str.Append("Текстовий звiт");
            str.Append("");
            
            str.Append($"\n{DateTime.Now:dd-MM-yyyy}");
            str.Append("");

            str.Append("\nСписок подiй:");
            Console.WriteLine("Якщо ви бажаєте зупинити цикл напишiть у наступну подiю exit");
            while(true)
            {
                string str_event = Console.ReadLine();
                if(string.Equals(str_event,"exit"))
                {
                    break;
                }
                str.Append($"\n*{str_event}");
            }
            Console.WriteLine();
            Console.WriteLine(str.ToString());
        }
    }
}
