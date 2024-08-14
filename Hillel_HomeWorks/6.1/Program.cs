using System;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обчислення середнього заробiтку");//1

            Console.Write("Input number of employees:");
            int count_salary = Convert.ToInt32(Console.ReadLine());
            int p_salary = 1, per_salary;
            double sum_salary = 0;
            while (p_salary != count_salary + 1)
            {
                Console.Write($"Input {p_salary} employee salary:");
                per_salary = Convert.ToInt32(Console.ReadLine());
                sum_salary += per_salary;
                p_salary++;
            }
            Console.WriteLine($"Average salary: {(sum_salary / count_salary):F2}");
////////////////////////////////////////////////////////////////////////////////////////*/
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Побудова графiку зiрочками");//2

            Console.Write("Input number of rows:");
            int count_star = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= count_star; i++)
            {
                for (int i_row = 1; i_row <= i; i_row++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
////////////////////////////////////////////////////////////////////////////////////////*/
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Генерацiя простих чисел");//3

            Console.Write("Input the number:");
            int number_prime = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number_prime; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
////////////////////////////////////////////////////////////////////////////////////////*/
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Генерацiя фiбоначчiвськоi послідовностi");//5

            Console.Write("Input the number:");
            int limit_fibo = Convert.ToInt32(Console.ReadLine());
            long a_fibo = 0, b_fibo = 1, c_fibo;
            for (int i = 0; i <= limit_fibo; i++)
            {
                Console.Write(a_fibo + " ");
                c_fibo = a_fibo + b_fibo;
                a_fibo = b_fibo;
                b_fibo = c_fibo;
            }
            Console.WriteLine();
////////////////////////////////////////////////////////////////////////////////////////*/
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Калькулятор оплати працi за годину");//6

            Console.Write("Enter the number of hours worked per day: ");
            int hour_work = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the hourly rate: ");
            double rate_work = Convert.ToInt32(Console.ReadLine());
            double dailypay_work = 0;

            for (int i = 0; i < hour_work; i++)
            {
                dailypay_work += rate_work;
            }
            Console.WriteLine($"The payment per day is: {dailypay_work}");
            ////////////////////////////////////////////////////////////////////////////////////////*/
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Генерацiя таблицi множення для конкретного числа");//7

            Console.Write("Input the number");
            int number_multi = Convert.ToInt32(Console.ReadLine());
            int result_multi;
            for (int i = 1; i <= 10; i++)
            {
                result_multi = i * number_multi;
                Console.WriteLine($"{number_multi} * {i} = {result_multi}");
            }
            ////////////////////////////////////////////////////////////////////////////////////////*/
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Перевiрка на простоту");//8

            Console.Write("Input the number: ");
            int digit_prime = Convert.ToInt32(Console.ReadLine());
            bool Prime = true;

            if (digit_prime <= 1)
            {
                Prime = false;
            }
            else
            {
                for (int i = 2; i <= digit_prime/2; i++)
                {
                    if (digit_prime % i == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
            }

            if (Prime)
            {
                Console.WriteLine("Is Prime");
            }
            else
            {
                Console.WriteLine("Isn't Prime");
            }
        }
    }
}
