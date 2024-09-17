using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _13._1
{
    class Program
    {
        static List<string> ToDoList = new List<string>();
        static List<bool> IsCompleted = new List<bool>();

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
                        AddToDo();
                        break;
                    case "2":
                        ShowToDo();
                        break;
                    case "3":
                        MarkToDo();
                        break;
                    case "4":
                        DeleteToDo();
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

        static void AddToDo()
        {
            Console.Write("Введіть назву нової справи: ");
            string newTask = Console.ReadLine();
            Console.WriteLine();
            ToDoList.Add(newTask);
            IsCompleted.Add(false);
            Console.WriteLine($"Справу {newTask} додано до списку.");
            Console.WriteLine();
        }

        static void ShowToDo()
        {
            if (ToDoList.Count == 0)
            {
                Console.WriteLine("Список справ порожній.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Ваші справи:");
                for (int i = 0; i < ToDoList.Count; i++)
                {
                    string status;
                    if (IsCompleted[i])
                    {
                        status = "Виконано!";
                    }
                    else
                    {
                        status = "Невиконано!";
                    }
                    Console.WriteLine($"{i + 1}. {ToDoList[i]} {status}");
                    Console.WriteLine();
                }
            }
        }
        static void MarkToDo()
        {
            ShowToDo();
            Console.Write("Введіть номер справи, яку хочете позначити як виконану: ");
            Console.WriteLine();

            string input = Console.ReadLine();
            int taskNumber = Convert.ToInt32(input);

            if (taskNumber > 0 && taskNumber <= ToDoList.Count)
            {
                IsCompleted[taskNumber - 1] = true;
                Console.WriteLine($"Справу {ToDoList[taskNumber - 1]} позначено як виконану.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Номер справи поза діапазоном.");
                Console.WriteLine();
            }
        }

        static void DeleteToDo()
        {
            ShowToDo();
            Console.Write("Введіть номер справи, яку хочете видалити: ");

            string input = Console.ReadLine();
            int taskNumber = Convert.ToInt32(input);

            if (taskNumber > 0 && taskNumber <= ToDoList.Count)
            {
                Console.WriteLine($"Справу {ToDoList[taskNumber - 1]} видалено.");
                Console.WriteLine();
                ToDoList.RemoveAt(taskNumber - 1);
                IsCompleted.RemoveAt(taskNumber - 1);
            }
            else
            {
                Console.WriteLine("Невірний номер справи.");
                Console.WriteLine();
            }
        }
    }
}