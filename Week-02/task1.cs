using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class BankAccount
    {
        public string AccountNumber;
        public string HolderName;
        public double Balance;
        public BankAccount(string accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }
        public void depositMoney(double depositAmount)
        {
            Balance = Balance + depositAmount;
        }
        public void withdrawMoney(double withdrawAmount)
        {
            if(withdrawAmount >  Balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                Balance = Balance - withdrawAmount;
            }
        }
        public void displayBalance()
        {
            Console.WriteLine("Balance is:" +  Balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            
            while (true)
            {
                Console.WriteLine("1. Open Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Display Account Details");
                Console.WriteLine("5. Exit");

                int option = int.Parse(Console.ReadLine());
                if(option == 1)
                {
                    Console.Write("Enter your name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the opening balance:");
                    double money = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the account number:");
                    string accountNo = Console.ReadLine();

                    BankAccount account = new BankAccount(accountNo, name, money);
                    accounts.Add(account);
                }
                else if(option == 2)
                {
                    Console.Write("Enter the account number in which you want to deposit money:");
                    string accountNum = Console.ReadLine();
                    Console.Write("Enter the amount you want to deposit:");
                    double amount = double.Parse(Console.ReadLine());

                    bool found = false;

                    for(int i=0;i<accounts.Count;i++)
                    {
                        if (accounts[i].AccountNumber == accountNum)
                        {
                            accounts[i].depositMoney(amount);
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Incorrect Account Number");
                    }
                }
                else if(option == 3)
                {
                    Console.Write("Enter the account number from you want to withdraw money:");
                    string accountNum = Console.ReadLine();
                    Console.Write("Enter the amount you want to withdraw:");
                    double amount = double.Parse(Console.ReadLine());

                    bool found = false;
                    for (int i = 0; i < accounts.Count; i++)
                    {
                        if (accounts[i].AccountNumber == accountNum)
                        {
                            accounts[i].withdrawMoney(amount);
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Incorrect Account Number");
                    }
                }
                else if(option == 4)
                {
                    Console.Write("Enter your account number:");
                    string accountNum = Console.ReadLine();
                    bool found = false;

                    for (int i = 0; i < accounts.Count; i++)
                    {
                        if (accounts[i].AccountNumber == accountNum)
                        {
                            accounts[i].displayBalance();
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Incorrect Account Number");
                    }

                }
                else if(option == 5)
                {
                    break;
                }
            }
        }
    }
}
