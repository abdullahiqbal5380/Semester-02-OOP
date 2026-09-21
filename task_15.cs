using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_2D
{
    internal class Program
    {
        static int PrintSum(int [,] cars)
        {
            int sum = 0;
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    sum = sum + cars[i,j];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[,] cars =
            {
                {10, 7, 12, 5, 7 },
                {10, 7, 12, 5, 7 },
                {10, 7, 12, 5, 7 },
                {10, 7, 12, 5, 7 },
                {10, 7, 12, 5, 7 },
            };
            int sum;
            sum = PrintSum(cars);
            Console.WriteLine("Sum is: {0}", sum);
            Console.Read();
        }
    }
}
