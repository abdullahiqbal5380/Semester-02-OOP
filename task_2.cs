using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Lilly's age:");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter the price of washing machine:");
            float machinePrice = float.Parse(Console.ReadLine());

            Console.Write("Enter the price of toy:");
            int unitPrice = int.Parse(Console.ReadLine());

            int count = 0;
            for(int i=1; i<= age; i = i + 2)
            {
                count = count + 1;
            }

            
            float amount = 0.00F;
            float sum = 0.00F;
            for(int i=2; i<=age; i = i + 2)
            {
                amount = amount + 10.00F;
                amount = amount - 1.00F;
                sum = sum + amount;
            }

            float price = count * unitPrice;
            float Money = sum + price;

            if (Money >= machinePrice)
            {
                float remainingMoney = Money - machinePrice;
                Console.WriteLine("Yes! {0}", remainingMoney);
            }
            else
            {
                float insufficientMoney = machinePrice - Money;
                Console.WriteLine("No! {0}", insufficientMoney);
            }
        }
    }
}
