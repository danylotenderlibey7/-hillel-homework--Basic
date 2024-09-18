using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    class ToDoManager
    {
        private static List<ToDoList> ToDoList = new List<ToDoList>();
        public static void AddToDo()
        {
            Console.Write("Введіть назву нової справи: ");
            string newTask = Console.ReadLine();
            Console.WriteLine();
            ToDoList.Add(new ToDoList(newTask));
            Console.WriteLine($"Справу {newTask} додано до списку.");
            Console.WriteLine();
        }
        public static void ShowToDo()
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
                    if (ToDoList[i].IsCompleted)
                    {
                        status = "Виконано!";
                    }
                    else
                    {
                        status = "Невиконано!";
                    }
                    Console.WriteLine($"{i + 1}. {ToDoList[i].name} {status}");
                    Console.WriteLine();
                }
            }
        }

        public static void MarkToDo()
        {
            ShowToDo();
            Console.Write("Введіть номер справи, яку хочете позначити як виконану: ");
            Console.WriteLine();

            string input = Console.ReadLine();
            int taskNumber = Convert.ToInt32(input);

            if (taskNumber > 0 && taskNumber <= ToDoList.Count)
            {
                ToDoList[taskNumber - 1].IsCompleted = true;
                Console.WriteLine($"Справу {ToDoList[taskNumber - 1]} позначено як виконану.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Номер справи поза діапазоном.");
                Console.WriteLine();
            }
        }

        public static void DeleteToDo()
        {
            ShowToDo();
            Console.Write("Введіть номер справи, яку хочете видалити: ");

            string input = Console.ReadLine();
            int taskNumber = Convert.ToInt32(input);

            if (taskNumber > 0 && taskNumber <= ToDoList.Count)
            {
                Console.WriteLine($"Справу {ToDoList[taskNumber - 1].name} видалено.");
                Console.WriteLine();
                ToDoList.RemoveAt(taskNumber - 1); 
            }
            else
            {
                Console.WriteLine("Невірний номер справи.");
                Console.WriteLine();
            }
        }

    }
}
