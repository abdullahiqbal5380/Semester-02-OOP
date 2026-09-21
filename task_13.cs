using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int sum=0;
            while(num != -1)
            {
                sum = sum + num;
                Console.Write("Enter the number:");
                num = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("The total sum is {0}", sum);
            Console.Read();
        }
    }
}
