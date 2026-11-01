using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    class Student
    {
        public string StudentID;
        public string StudentName;
        public double GPA;
        public Student()
        {

        }
        public Student(string ID, string Name, double gpa)
        {
            StudentID = ID;
            StudentName = Name;
            GPA = gpa;
        }
        public void display()
        {
            Console.WriteLine("Student ID is:" + StudentID);
            Console.WriteLine("Student Name is:" + StudentName);
            Console.WriteLine("Student GPA is:" + GPA);
        }
        public void updateGPA(double gpa)
        {
            GPA = gpa;
        }
        public void honorRoll()
        {
            if (GPA >= 3.5)
            {
                Console.WriteLine(StudentName);
            }
            else
            {
                Console.WriteLine("GPA is less than 3.5");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Display student details");
                Console.WriteLine("3. Update GPA");
                Console.WriteLine("4. Honor Roll");
                Console.WriteLine("5. Exit");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter the ID:");
                    string id = Console.ReadLine();
                    Console.WriteLine("Enter the name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the gpa:");
                    double gpa = double.Parse(Console.ReadLine());

                    Student s = new Student(id, name, gpa);
                    students.Add(s);
                }

                else if (option == 2)
                {
                    foreach (Student student in students)
                    {
                        student.display();
                    }
                }

                else if (option == 3)
                {
                    searchUpdate();

                }
                else if(option == 4)
                {
                    foreach(Student student in students)
                    {
                        student.honorRoll();
                    }

                }
                else if(option == 5)
                {
                    break;
                }


                void searchUpdate()
                {
                    Console.WriteLine("Enter the studentID:");
                    string id = Console.ReadLine();
                    Console.WriteLine("Enter the gpa you want to update:");
                    double gpa = double.Parse(Console.ReadLine());

                    bool found = false;
                    foreach (Student student in students)
                    {
                        if (student.StudentID == id)
                        {
                            student.updateGPA(gpa);
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Student not found");
                    }
                }
            }
        }
    }
}
