using System;

namespace _9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");//1
            int[] array_secondmax = new int[20];
            Random random = new Random();

            Console.Write($"Array: ");
            for (int i = 0; i < array_secondmax.Length; i++)
            {
                array_secondmax[i] = random.Next(0, 151);
                Console.Write($"{array_secondmax[i]} ");
            }

            int max_first = array_secondmax[0];
            int max_second = max_first;

            for (int i = 0; i < array_secondmax.Length; i++)
            {
                if (array_secondmax[i] > max_first)
                {
                    max_second = max_first;
                    max_first = array_secondmax[i];
                }
                else if (array_secondmax[i] > max_second && array_secondmax[i] < max_first)
                {
                    max_second = array_secondmax[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"First Max: {max_first}");
            Console.WriteLine($"Second Max: {max_second}");

            ////////////////////////////////////////////////////////////////////////////////////////*/
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Task 2");//2
            int[,] array_sort = new int[7, 7];

            Console.WriteLine("Array:");
            for (int i = 0; i < array_sort.GetLength(0); i++)
            {
                for (int j = 0; j < array_sort.GetLength(1); j++)
                {
                    array_sort[i, j] = random.Next(0, 101);
                    Console.Write($"{array_sort[i, j]} \t");
                }
                Console.WriteLine();
            }

            int[] array_temp = new int[array_sort.GetLength(0) * array_sort.GetLength(1)];
            int i_temp = 0;
            for (int i = 0; i < array_sort.GetLength(0); i++)
            {
                for (int j = 0; j < array_sort.GetLength(1); j++)
                {
                    array_temp[i_temp] = array_sort[i, j];
                    i_temp++;
                }
            }

            int temp;
            for (int i = 0; i < array_temp.Length; i++)
            {
                for (int j = 0; j < array_temp.Length - i - 1; j++)
                {
                    if (array_temp[j] > array_temp[j + 1])
                    {
                        temp = array_temp[j];
                        array_temp[j] = array_temp[j + 1];
                        array_temp[j + 1] = temp;
                    }
                }
            }

            int i_temp2 = 0;
            for (int i = 0; i < array_sort.GetLength(0); i++)
            {
                for (int j = 0; j < array_sort.GetLength(1); j++)
                {
                    array_sort[i, j] = array_temp[i_temp2];
                    i_temp2++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < array_sort.GetLength(0); i++)
            {
                for (int j = 0; j < array_sort.GetLength(1); j++)
                {
                    Console.Write($"{array_sort[i, j]} \t");
                }
                Console.WriteLine();
            }
            ////////////////////////////////////////////////////////////////////////////////////////*/
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Task 3");//3

            int[] array_x = new int[10];

            Console.WriteLine("Array:");
            for (int i = 0; i < array_x.Length; i++)
            {
                array_x[i] = random.Next(-20, 21);
                Console.Write($"{array_x[i]} ");
            }

            Console.WriteLine();
            Console.Write("Input an index to delete: ");
            int index = Convert.ToInt32(Console.ReadLine());

            int[] array_y = new int[array_x.Length - 1];
            int p = 0;

            for (int i = 0; i < array_x.Length; i++)
            {
                if (i != index) 
                {
                    array_y[p] = array_x[i];
                    p++;
                }
            }

            Console.WriteLine("Array after deletion:");
            for (int i = 0; i < array_y.Length; i++)
            {
                Console.Write($"{array_y[i]} ");
            }
            Console.WriteLine();

            ////////////////////////////////////////////////////////////////////////////////////////*/
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Task 4");//4

            int[,] array_matrix = new int[5, 5];
            Console.WriteLine("Array:");
            for (int i = 0; i < array_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < array_matrix.GetLength(1); j++)
                {
                    array_matrix[i, j] = random.Next(-15, 21);
                    Console.Write($"{array_matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            int sum1 = 0, sum2 = 0;//сума однієї та другої діагональ

            for (int i = 0; i < array_matrix.GetLength(0); i++)
            {
                sum1 += array_matrix[i, i];
            }
            for (int i = 0; i < array_matrix.GetLength(0); i++)
            {
                sum2 += array_matrix[i, array_matrix.GetLength(1) - 1 - i];
            }
            Console.WriteLine();
            Console.WriteLine($"Sum of first diagonal: {sum1}");
            Console.WriteLine($"Sum of second diagonal: {sum2}");
        }
    }
}
