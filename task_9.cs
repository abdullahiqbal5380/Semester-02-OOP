using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class Program
    {
        static void ReadData(string path, string[] name, int[] orders, int[][] prices)
        {
            
            int x = 0;

            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while((record = fileVariable.ReadLine()) != null)
                {
                    name[x] = parseData(record, 1);
                    orders[x] = int.Parse(parseData(record, 2));
                    prices[x] = parsePrices(record);
                    x++;
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }

        static string parseData(string record, int field)
        {
            string item = "";
            int space = 1;
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ' ')
                {
                    space++;
                }
                else if (space == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }

        static int[] parsePrices(string record)
        {
            int start = 0;

            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == '[')
                {
                    start = i + 1;
                    break;
                }
            }
            string data = "";
            for(int i = start; i < record.Length; i++)
            {
                if (record[i] == ']')
                {
                    break;

                }

                data = data + record[i];
            }
            string[] values = data.Split(',');
            int[] prices = new int[values.Length];

            for(int i=0;i<values.Length; i++)
            {
                prices[i] = int.Parse(values[i]);
            }
            return prices;
        }

        static void pizza_points(int order, int price, string[] name, int[] orders, int[][] prices )
        {
            for(int i=0; i<50; i++)
            {
                int count = 0;
                for(int j=0; j < prices[i].Length; j++)
                {
                    if (prices[i][j] >= price)
                    {
                        count++;
                    }
                }
                if(count >= order)
                {
                    Console.WriteLine(name[i]);
                }
            }
            
        }
        static void Main(string[] args)
        {
            string path = "C:\\Users\\wajid\\OneDrive\\Desktop\\Semester-2\\OOPS\\Week-1";
            string[] name = new string[50];
            int[] orders = new int[50];
            int[][] prices = new int[50][];
           
                ReadData(path, name, orders, prices);
                Console.WriteLine("Enter the orders:");
                int order = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter minimun order price:");
                int price = int.Parse(Console.ReadLine());

                pizza_points(order, price, name, orders, prices);
                Console.ReadKey();
        }
    }
}
