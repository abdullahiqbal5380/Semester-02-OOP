using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length:");
            float length = float.Parse(Console.ReadLine());

            float area = length * length;
            Console.WriteLine("The area is:");
            Console.Write(area);
            Console.ReadKey();
        }
    }
}
