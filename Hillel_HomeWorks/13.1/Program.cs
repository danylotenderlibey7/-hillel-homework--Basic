using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _13._1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            bool IsRunning = true;
            while (IsRunning)
            {
                Console.WriteLine("1. Додати нову справу");
                Console.WriteLine("2. Вивести всі справи");
                Console.WriteLine("3. Позначити справу як виконану");
                Console.WriteLine("4. Видалити справу");
                Console.WriteLine("5. Вийти");
                Console.Write("Оберіть опцію:");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ToDoManager.AddToDo();
                        break;
                    case "2":
                        ToDoManager.ShowToDo();
                        break;
                    case "3":
                        ToDoManager.MarkToDo();
                        break;
                    case "4":
                        ToDoManager.DeleteToDo();
                        break;
                    case "5":
                        IsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір");
                        break;
                }
            }
        }
        
    }
}