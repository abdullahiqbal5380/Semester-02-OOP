using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the marks:");
            float marks = float.Parse(Console.ReadLine());

            if(marks > 50)
            {
                Console.WriteLine("You are passed!");

            }
            else
            {
                Console.WriteLine("You are failed.");

            }
            Console.ReadKey();
        }
    }
}
