using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        public BankAccount(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Kwota wpłaty musi być większa od zera.");
            }
            else
            {
                balance += amount;
                Console.WriteLine("Wpłacono: " + amount);
                Console.WriteLine("Saldo po wpłacie: " + balance);
            }

        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Kwota wypłaty musi być większa od zera.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Niewystarczające środki na koncie.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Wypłacono: " + amount);
                Console.WriteLine("Saldo po wypłacie: " + balance);
            }
        }

    }
}
