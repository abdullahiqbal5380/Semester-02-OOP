using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_03
{
    public class ATM
    {
        public float balance;
        List<string> transactionHistory = new List<string>();

        public ATM(float initialBalance)
        {
            balance = initialBalance;
        }

        public void deposit(float amount)
        {
            balance = balance + amount;
            transactionHistory.Add("Deposited:" + amount);
        }

        public void withdraw(float amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("INSUFFICIENT BALANCE");
            }
            else
            {
                balance = balance - amount;
                transactionHistory.Add("Withdrawn:" + amount);
            }
        }

        public float check_balance()
        {
            return balance;
        }

        public void transaction_history()
        {
            Console.WriteLine("Transaction history:");
            for (int i = 0; i < transactionHistory.Count; i++)
            {
                Console.WriteLine(transactionHistory[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm1 = new ATM(2000);
            atm1.deposit(300);
            atm1.withdraw(1000);

            Console.WriteLine("Current balance:" + atm1.check_balance());
            atm1.transaction_history();
        }
    }
}
