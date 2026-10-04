using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_1
{
    internal class Program
    {
        class Circle
        {
            public double radius;
            public string color;
            public Circle(double r, string c)
            {
                radius = r;
                color = c;
            }
            public Circle()
            {
                radius = 1.0;
                color = "red";
            }
            public Circle(double r)
            {
                radius = r;
            }
        }
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine(c1.radius);
            Console.WriteLine(c1.color);
            Circle c2 = new Circle(20.6);
            Console.WriteLine(c2.radius);
            Circle c3 = new Circle(3.5, "blue");
            Console.WriteLine(c3.radius);
            Console.WriteLine(c3.color);

        }

    }
}
