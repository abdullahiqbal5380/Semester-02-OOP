using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class student
    {
        public string name;
        public float EcatMarks;
        public float FSCMarks;
        public float MatricMarks;
        public float Aggregate;

        public student()
        {

        }
        public student(student s)
        {
            name = s.name;
            EcatMarks = s.EcatMarks;
            FSCMarks = s.FSCMarks;
            MatricMarks = s.MatricMarks;
            Aggregate = s.Aggregate;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.name = "Ali";
            s.EcatMarks = 300;
            s.FSCMarks = 1100;
            s.MatricMarks = 800;

            student s2 = new student(s);
            s2.name = "Abdullah";
           

            Console.WriteLine(s.name);
            Console.WriteLine(s2.name);
            Console.WriteLine(s2.EcatMarks);

            Console.ReadKey();

        }
    }
}
