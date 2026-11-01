using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFunction
{
    internal class Program
    {
        static int add(int n1, int n2)
        {
            return n1 + n2;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            int result = add(num1, num2);
            Console.WriteLine("Sum is: {0}",result);
        }
    }
}
