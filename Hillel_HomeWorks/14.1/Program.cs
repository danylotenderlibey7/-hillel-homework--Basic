using System;

namespace _14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account heikkisAccount = new Account("Heikki", 6584);
            Account joansAccount = new Account("Joan", 69784);
            Account lisasAccount = new Account("Lisa", 64);
            Account mandysAccount = new Account("Mandy", 123);
            Account danilAccount = new Account("Danil", 14845);


            heikkisAccount.WithdrawMoney(420);
            Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.Balance + "$");
            Console.WriteLine();

            joansAccount.WithdrawMoney(69784);
            Console.WriteLine("The balance of Joan's account is now: " + joansAccount.Balance + "$");
            Console.WriteLine();

            lisasAccount.PutMoney(123);
            Console.WriteLine("The balance of Lisa's account is now: " + lisasAccount.Balance + "$");
            Console.WriteLine();

            mandysAccount.WithdrawMoney(125);
            Console.WriteLine("The balance of Mandy's account is now: " + mandysAccount.Balance + "$");
            Console.WriteLine();

            danilAccount.PutMoney(-589);
            Console.WriteLine("The balance of Danil's account is now: " + danilAccount.Balance + "$");
            Console.WriteLine();

        }
    }
}
