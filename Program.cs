using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("1234567890", 1000);

            Console.WriteLine("Numer konta: " + account.GetAccountNumber());
            Console.WriteLine("Saldo początkowe: " + account.GetBalance());
            account.Deposit(1000);
            account.Withdraw(20);
        }
    }
}
