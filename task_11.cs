using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signin_Signup
{
    internal class Program
    {
        static int menu()
        {
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        static void readData(string path, string[] names, string[] passwords)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                int x = 0;
                while ((record = fileVariable.ReadLine()) != null) {
                    names[x] = parseData(record, 1);
                    passwords[x] = parseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }

            static string parseData(string record, int field)
            {
                int comma = 1;
                string item = "";
                for (int i = 0; i < record.Length; i++)
                {
                    if (record[i] == ',')
                    {
                        comma++;
                    }
                    else if (comma == field)
                    {
                        item = item + record[i];
                    }
                }
            return item;
        }
            static void signIn(string n, string p, string[] names, string[] passwords)
            {
                bool flag = false;
                for (int i = 0; i < 5; i++)
                {
                if (n == names[i] && p == passwords[i])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                    break;
                }
                }

            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
                        
            }
            static void signUp(string path, string n, string p)
                {
                    StreamWriter file = new StreamWriter(path, true);
                    file.WriteLine(n + "," + p);
                    Console.WriteLine("Account created!");
                    file.Flush();
                    file.Close();
                }

            static void Main(string[] args)
            {
                    string path = "C:\\Users\\wajid\\OneDrive\\Desktop\\Semester-2\\OOPS\\Week-1\\Signin_SignUp.txt";
                    string[] names = new string[5];
                    string[] passwords = new string[5];
                    int option;
            do
            {
                readData(path, names, passwords);
                option = menu();
                Console.Clear();
                
                if (option == 1)
                {
                    Console.WriteLine("Enter the Name:");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter the Password:");
                    string p = Console.ReadLine();
                    signIn(n, p, names, passwords);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter New Name:");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter New password:");
                    string p = Console.ReadLine();
                    signUp(path, n, p);
                }
            }
            while (option < 3);
                    Console.ReadKey();
                    
            }
        }
    }
