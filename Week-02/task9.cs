using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharamcy_system
{
    class Medicine
    {
        public string Title;
        public DateTime expiryDate;
        public double Price;
        public Medicine(string title, DateTime expiry, double price)
        {
            Title = title;
            expiryDate = expiry;
            Price = price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Medicine> medicine = new List<Medicine>();
           
            string path = "C:\\Users\\wajid\\OneDrive\\Desktop\\Semester-2\\OOPS\\Week-2\\Pharamcy system\\medicines.txt";

            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                string record = "";
                
                while((record = sr.ReadLine()) != null)
                {
                    string title = parseData(record, 1);
                    string expiry = parseData(record, 2);
                    double price = double.Parse(parseData(record, 3));

                    Medicine m = new Medicine(title, DateTime.Parse(expiry), price);
                    medicine.Add(m);
                }
                sr.Close();
            }
            else
            {
                Console.WriteLine("File does not exists");
            }

            display();

            void display()
            {
                foreach (Medicine m in medicine)
                {
                    Console.WriteLine(m.Title + "," + m.expiryDate + "," + m.Price);
                }
            }


            string parseData(string record, int field)
            {
                int comma = 1;
                string item = "";
                for (int i = 0; i < record.Length; i++)
                {
                    if (record[i] == ',')
                    {
                        comma++;
                    }
                    else if(comma == field)
                    {
                        item = item + record[i];
                    }
                }
                return item;
            }
        }
    }
}
