using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplicationDemo
{
    public class BankAccount
    {
        //private data memeber
        private decimal _balance;
        //private string _name;
        //private string _email;
        //private long _acccountNumber;


        public BankAccount(decimal intialBalance)
        {
            this._balance = intialBalance;
        }

        public void Deposit(decimal amount)
        {
            // _balance = _balance + amount ;
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (_balance>= amount){
                _balance -= amount;
            }

            else
            {
                Console.WriteLine("Insufficient funds");
            }

        }

        public decimal GetBalance() { return _balance; }
    }
}
