using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplicationDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(10000);
            Console.WriteLine("Intial balance ");
            bankAccount.GetBalance();

            bankAccount.Deposit(500);

            bankAccount.Deposit(50000);
            bankAccount.Withdraw(900);


            Console.WriteLine("Bank Balance : {0}",bankAccount.GetBalance().ToString());
            Console.WriteLine("Bank Balance : {0}",bankAccount.GetBalance().ToString());

            Console.WriteLine("Bank Balance : {0}",bankAccount.GetBalance().ToString());
            Console.WriteLine("Bank Balance : {0}",bankAccount.GetBalance().ToString());Console.WriteLine("Bank Balance : {0}",bankAccount.GetBalance().ToString());
            Console.WriteLine("Bank Balance : {0}",bankAccount.GetBalance().ToString());
        }
    }
}
