using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01
{
    public class Transaction
    {
        public string Id;
        public string Name;
        public float Amount;
        public string Date;
        public string Time;

        public Transaction()
        {

        }

        public Transaction(Transaction t)
        {
            Name = t.Name;
            Id = t.Id;
            Amount = t.Amount;
            Date = t.Date;
            Time = t.Time;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction();
            t1.Id = "01234a";
            t1.Name = "Laptop";
            t1.Amount = 80000;
            t1.Date = "13 Sep";
            t1.Time = "7 pm";

            Transaction t2 = new Transaction(t1);                            //Copy constructor 

            t2.Name = "PC";
      
            Console.WriteLine(t2.Name);
            Console.WriteLine(t1.Name);
        }
    }
}
