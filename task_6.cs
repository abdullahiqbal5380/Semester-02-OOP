using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is:");
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
