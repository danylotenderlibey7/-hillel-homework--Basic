using System;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");//1

            int[] array = new int[10];
            Random random = new Random();
            Console.Write($"Array: ");
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = random.Next(-10, 11);
                Console.Write($"{array[i]} "); //<-- для перевірки, чи правильне число під індексом
            }
            Console.WriteLine();
            Console.Write("Array with paired indexes: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.Write($"{array[i]} ");
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////*/
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Task 2");//2
            int sum_array = 0;
            int sum_pairedindex = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                sum_array += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum_pairedindex += array[i];
                }
            }
            Console.WriteLine($"Sum of all elements: {sum_array}");
            Console.WriteLine($"Sum of paired index elements: {sum_pairedindex}");
            if (sum_array < 0)
            {
                Console.WriteLine("The sum of all elements is negative");
            }
            else if (sum_array > 0) 
            {
                Console.WriteLine("The sum of all elements is positive");
            }
            else
            {
                Console.WriteLine("The sum of all elements is 0");
            }

            if (sum_pairedindex < 0)
            {
                Console.WriteLine("The sum of paired index elements is negative");
            }
            else if (sum_pairedindex > 0)
            {
                Console.WriteLine("The sum of paired index elements is positive");
            }
            else
            {
                Console.WriteLine("The sum of paired index elements is 0");
            }
            //! з умови задачі не дуже зрозумів суму яких саме елементів потрібно знайти, чи парних з масиву чи всіх, тому знайшов і для тих і для тих
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Task 3");//3

            int[,] array_multiplication = new int[9, 9];
            for (int i = 0; i < array_multiplication.GetLength(0); i++) 
            {
                for( int j = 0; j < array_multiplication.GetLength(1); j++)
                {
                    array_multiplication[i, j] = (i + 1) * (j + 1);
                }
            }
            for (int i = 0; i < array_multiplication.GetLength(0); i++)
            {
                for (int j = 0; j < array_multiplication.GetLength(1); j++)
                {
                    Console.Write($"{array_multiplication[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Task 4");//4

            int[,] array_random = new int[5, 5];
            for (int i = 0; i < array_random.GetLength(0); i++) 
            {
                for (int j = 0; j < array_random.GetLength(1); j++) 
                {
                    array_random[i, j] = random.Next(-25, 26);
                    Console.Write($"{array_random[i, j]} \t");
                }
                Console.WriteLine();
            }
            int max_val = array_random[0, 0];
            int min_val = array_random[0, 0];
            int i_max = 0, j_max = 0;
            int i_min = 0, j_min = 0;

            for (int i = 0; i < array_random.GetLength(0); i++)
            {
                for (int j = 0; j < array_random.GetLength(1); j++)
                {
                    if (array_random[i, j] > max_val) 
                    {
                        max_val = array_random[i, j];
                        i_max = i; j_max = j;
                    }
                    if (array_random[i, j] < min_val)
                    {
                        min_val = array_random[i, j];
                        i_min = i; j_min = j;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Maximum element of array {max_val}");
            Console.WriteLine($"Maximum element coordinates: {i_max+1} Row; {j_max+1} Column");

            Console.WriteLine($"Minimal element of array {min_val}");
            Console.WriteLine($"Minimal element coordinates: {i_min+1} Row; {j_min+1} Column");
        }
    }
}
