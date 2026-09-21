using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\wajid\\OneDrive\\Desktop\\Semester-2\\OOPS\\Week-1";
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string record;
                while((record = sr.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                sr.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
    }
}
