using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class MUser
    {
        public string Username;
        public string Password;
        public string Role;
        public void loadData(string record)
        {
            Username = parseData(record, 1);
            Password = parseData(record, 2);
            Role = parseData(record, 3);
        }
        public string parseData(string record, int index)
        {
            int comma = 1;
            string item = "";
            for(int i=0; i<record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                }
                else if(comma == index)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("users.txt");
            string record;
            while ((record = sr.ReadLine()) != null)
            {
                MUser user = new MUser();
                user.loadData(record);
            }
            sr.Close();
        }
    }
}
