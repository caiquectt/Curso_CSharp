using System;
using System.Globalization;
using Exe1.Entities;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            try{
                Console.WriteLine("Enter account data:");
                System.Console.Write("Number: ");
                acc.Number = int.Parse(Console.ReadLine());

                System.Console.Write("Holder: ");
                acc.Holder = Console.ReadLine();

                System.Console.Write("Initial balance: ");
                acc.Balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.Write("Withdraw limit: ");
                acc.WithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.WriteLine();
                System.Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(amount);

                System.Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e){
                System.Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e){
                System.Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
