using HotelManagementSystem.Booking;
using HotelManagementSystem.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Guest
{
    public class HotelUI
    {
        GuestUI guestUI = new GuestUI();
        RoomUI roomUI = new RoomUI();
        BookingUI bookingUI = new BookingUI();

        public void MainMenu()
        {
            string choice = "";

            while (true)
            {
                Console.Clear();

                Console.WriteLine("===== HOTEL MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Guest");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    if (AdminLogin())
                    {
                        ShowAdminMenu();
                    }
                }
                else if (choice == "2")
                {
                    guestUI.GuestMenu();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Thank you for visiting!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                    Console.ReadKey();
                }
            }
        }

        public bool AdminLogin()
        {
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Clear();
                Console.WriteLine("======= ADMIN LOGIN =======");

                Console.WriteLine("Enter Username:");
                string username = Console.ReadLine();

                Console.WriteLine("Password:");
                string password = Console.ReadLine();

                if (username == "admin" && password == "admin123")
                {
                    Console.WriteLine("Login successful!");
                    Console.ReadKey();
                    return true;
                }

                attempts++;
                Console.WriteLine("Invalid username or password.");
                Console.ReadKey();
            }

            Console.WriteLine("Maximum attempts reached.");
            Console.ReadKey();

            return false;
        }

        public void ShowAdminMenu()
        {
            string choice = "";

            while (true)
            {
                Console.Clear();

                Console.WriteLine("======= ADMIN MENU =======");
                Console.WriteLine("1. Show All Guests");
                Console.WriteLine("2. Show All Bookings");
                Console.WriteLine("3. Search Guest");
                Console.WriteLine("4. Update Guest Record");
                Console.WriteLine("5. Check-out Guest");
                Console.WriteLine("6. View Room Availability");
                Console.WriteLine("7. Generate Revenue Report");
                Console.WriteLine("8. Logout");
                Console.Write("Enter choice: ");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    guestUI.ShowAllGuests();
                }
                else if (choice == "2")
                {
                    bookingUI.ShowAllBookings();
                }
                else if (choice == "3")
                {
                    guestUI.SearchGuest();
                }
                else if (choice == "4")
                {
                    guestUI.UpdateGuest();
                }
                else if (choice == "5")
                {
                    bookingUI.CheckoutGuest();
                }
                else if (choice == "6")
                {
                    roomUI.ShowRoomAvailability();
                }
                else if (choice == "7")
                {
                    bookingUI.GenerateRevenueReport();
                }
                else if (choice == "8")
                {
                    Console.WriteLine("Logged out.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}

