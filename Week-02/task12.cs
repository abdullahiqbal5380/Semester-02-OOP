using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_02
{
    public class Calculator
    {
        public float n1;
        public float n2;

        public Calculator(float num1, float num2)
        {
            n1 = num1;
            n2 = num2;
        }

        public float Add()
        {
            return n1 + n2;
        }
        public float Subtract()
        {
            return n1 - n2;
        }
        public float Multiply()
        {
            return n1 * n2;
        }
        public float Divide()
        {
            return n1 / n2;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation:");
            char ch = char.Parse(Console.ReadLine());

            Calculator calc = new Calculator(n1, n2);

            if (ch == '+')
            {
                Console.WriteLine("Result = " + calc.Add());

            }

            if (ch == '-')
            {
                Console.WriteLine("Result = " + calc.Subtract());

            }

            if (ch == '*')
            {
                Console.WriteLine("Result = " + calc.Multiply());

            }

            if (ch == '/')
            {
                Console.WriteLine("Result = " + calc.Divide());

            }
        }
    }
}
