using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Product
    {
        List<Product> products = new List<Product>();
        public string ID;
        public string Name;
        public double price;
        public string category;
        public string brandName;
        public string country;

        public void addProduct()
        {
            Product p = new Product();

            Console.Write("Enter product ID:");
            p.ID = Console.ReadLine();
            Console.Write("Enter product Name:");
            p.Name = Console.ReadLine();
            Console.Write("Enter the price:");
            p.price = double.Parse(Console.ReadLine());
            Console.Write("Enter the category:");
            p.category = Console.ReadLine();
            Console.Write("Enter the brand Name:");
            p.brandName = Console.ReadLine();
            Console.Write("Enter the country:");
            p.country = Console.ReadLine();

            products.Add(p);
        }

        public void showProducts()
        {
            foreach(Product p in products)
            {
                Console.WriteLine("ID:" + p.ID);
                Console.WriteLine("Name:" + p.Name);
                Console.WriteLine("Price:" + p.price);
                Console.WriteLine("Category:" + p.category);
                Console.WriteLine("Brand Name:" + p.brandName);
                Console.WriteLine("Country:" + p.country);
                Console.WriteLine("------------");
            }
        }

        public void storeWorth()
        {
            double sum = 0;
            foreach (Product p in products)
            {
                sum = sum + p.price;
            }
            Console.WriteLine("Total Store Worth:" + sum);
            Console.WriteLine("");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            while (true)
            {
                Console.WriteLine("1. Add Products");
                Console.WriteLine("2. Show Products");
                Console.WriteLine("3. Total Store Worth");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter the option:");
                int option = int.Parse(Console.ReadLine());

                
                if (option == 1)
                {
                    product.addProduct();
                }
                else if (option == 2)
                {
                    product.showProducts();
                }
                else if (option == 3)
                {
                    product.storeWorth();
                }
                else if(option == 4)
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid option");
                }

            }
        }
    }
}
