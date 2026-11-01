using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter the number at index {0}:", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int largest = numbers[0];
            for(int i=1; i<3; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine("The largest number is {0}:", largest);
        }
    }
}
