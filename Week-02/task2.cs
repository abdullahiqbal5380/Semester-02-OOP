using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        public string carID;
        public string Model;
        public double Price;

        public Car(string ID, string model, double price)
        {
            carID = ID;
            Model = model;
            Price = price;
        }
        public void display()
        {
            Console.WriteLine("CarID:" + carID);
            Console.WriteLine("Model of car:" +  Model);
            Console.WriteLine("Price of car:"+ Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            while (true)
            {
                Console.WriteLine("1. Add car");
                Console.WriteLine("2. View all cars");
                Console.WriteLine("3. Most expensive car");
                Console.WriteLine("4. Exit");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter the car ID:");
                    string id = Console.ReadLine();
                    Console.WriteLine("Enter the car model:");
                    string model = Console.ReadLine();
                    Console.WriteLine("Enter the car price:");
                    double price = double.Parse(Console.ReadLine());

                    Car c = new Car(id, model, price);
                    cars.Add(c);

                }
                else if (option == 2)
                {
                    foreach (Car car in cars)
                    {
                        car.display();
                    }
                }
                else if (option == 3)
                {
                    if(cars.Count == 0)
                    {
                        Console.WriteLine("No cars available");
                    }
                    
                    double expensiveCar = cars[0].Price;
                    string model = "";

                    for (int i = 1; i < cars.Count; i++)
                    {
                        if (cars[i].Price > expensiveCar)
                        {
                            expensiveCar = cars[i].Price;
                            model = cars[i].Model;

                        }

                    }
                    Console.WriteLine("Most expensive car is:" + model);
                }
                else if (option == 4)
                {
                    break;
                }
            }
        }
    }
}
