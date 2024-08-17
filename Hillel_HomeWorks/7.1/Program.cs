using System;

namespace _7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char x1 = '1', x2 = '2', x3 = '3', x4 = '4', x5 = '5', x6 = '6', x7 = '7', x8 = '8', x9 = '9';
            bool x1_access = true, x2_access = true, x3_access = true, x4_access = true, x5_access = true, 
            x6_access = true, x7_access = true, x8_access = true, x9_access = true;
            bool isDraw = false;
            char symbol;
            int operation;
            Console.WriteLine();
            Console.WriteLine($" {x1} | {x2} | {x3}");
            Console.WriteLine($"-----------");
            Console.WriteLine($" {x4} | {x5} | {x6}");
            Console.WriteLine($"-----------");
            Console.WriteLine($" {x7} | {x8} | {x9}");
            Console.WriteLine();
            for (int i = 1; i <= 9; i++) 
            {
                if (i % 2 == 1) 
                {
                    Console.Write("X Turn: Choose your number:");
                    symbol = 'X';
                }
                else
                {
                    Console.Write("O Turn: Choose your number:");
                    symbol = 'O';
                }
                operation = Convert.ToInt32(Console.ReadLine());
                switch(operation)
                {
                    case 1:
                        if (x1_access == false)
                        {
                            Console.WriteLine("You've already put this number. Choose other number.");
                            i--;
                            break;
                        }
                        else
                        {
                            x1 = symbol;
                            x1_access = false;
                            break;
                        }
                    case 2:
                        if (x2_access == false)
                        {
                            Console.WriteLine("You've already put this number. Choose other number.");
                            i--;
                            break;
                        }
                        else
                        {
                            x2 = symbol;
                            x2_access = false;
                            break;
                        }
                    case 3:
                        if (x3_access == false)
                        {
                            Console.WriteLine("You've already put this number. Choose other number.");
                            i--;
                            break;
                        }
                        else
                        {
                            x3 = symbol;
                            x3_access = false;
                            break;
                        }
                    case 4:
                        if (x4_access == false)
                        {
                            Console.WriteLine("You've already put this number. Choose other number.");
                            i--;
                            break;
                        }
                        else
                        {
                            x4 = symbol;
                            x4_access = false;
                            break;
                        }
                    case 5:
                        if (x5_access == false)
                        {
                            Console.WriteLine("You've already put this number. Choose other number.");
                            i--;
                            break;
                        }
                        else
                        {
                            x5 = symbol;
                            x5_access = false;
                            break;
                        }
                    case 6:
                        if (x6_access == false)
                        {
                            Console.WriteLine("You've already put this number. Choose other number.");
                            i--;
                            break;
                        }
                        else
                        {
                            x6 = symbol;
                            x6_access = false;
                            break;
                        }
                    case 7:
                        if (x7_access == false)
                        {
                            Console.WriteLine("You've already put this number. Choose other number.");
                            i--;
                            break;
                        }
                        else
                        {
                            x7 = symbol;
                            x7_access = false;
                            break;
                        }
                    case 8:
                        if (x8_access == false)
                        {
                            Console.WriteLine("You've already put this number. Choose other number.");
                            i--;
                            break;
                        }
                        else
                        {
                            x8 = symbol;
                            x8_access = false;
                            break;
                        }
                    case 9:
                        if (x9_access == false)
                        {
                            Console.WriteLine("You've already put this number. Choose another number.");
                            i--;
                            break;
                        }
                        else
                        {
                            x9 = symbol;
                            x9_access = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Something went wrong. Try again.");
                        i--;
                        break;

                }

                Console.WriteLine();
                Console.WriteLine($" {x1} | {x2} | {x3}");
                Console.WriteLine($"-----------");
                Console.WriteLine($" {x4} | {x5} | {x6}");
                Console.WriteLine($"-----------");
                Console.WriteLine($" {x7} | {x8} | {x9}");
                Console.WriteLine();

                if (x1 == x2 && x2 == x3 && x1 == x3) 
                {
                    Console.WriteLine($"Congratulations Player {x1} won!");
                    isDraw = false;
                    break;
                }
                else if(x4 == x5 && x5 == x6 && x4 == x6)
                {
                    Console.WriteLine($"Congratulations Player {x4} won!");
                    isDraw = false;
                    break;
                }
                else if (x7 == x8 && x8 == x9 && x7 == x9)
                {
                    Console.WriteLine($"Congratulations Player {x8} won!");
                    isDraw = false;
                    break;
                }
                else if (x1 == x4 && x4 == x7 && x7 == x1)
                {
                    Console.WriteLine($"Congratulations Player {x1} won!");
                    isDraw = false;
                    break;
                }
                else if (x2 == x5 && x5 == x8 && x8 == x2)
                {
                    Console.WriteLine($"Congratulations Player {x2} won!");
                    isDraw = false;
                    break;
                }
                else if (x3 == x6 && x6 == x9 && x3 == x9)
                {
                    Console.WriteLine($"Congratulations Player {x3} won!");
                    isDraw = false;
                    break;
                }
                else if (x1 == x5 && x5 == x9 && x1 == x9)
                {
                    Console.WriteLine($"Congratulations Player {x1} won!");
                    isDraw = false;
                    break;
                }
                else if (x7 == x5 && x5 == x3 && x3 == x7)
                {
                    Console.WriteLine($"Congratulations Player {x7} won!");
                    isDraw = false;
                    break;
                }
                else
                {
                    isDraw = true;
                }
            }
            if (isDraw)
            {
                Console.WriteLine("It's Draw!");
            }
        }
    }
}
