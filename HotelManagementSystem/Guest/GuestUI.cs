using HotelManagementSystem.Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Guest
{
    public class GuestUI
    {
        GuestService guestService = new GuestService();
        BookingUI bookingUI = new BookingUI();
        public void GuestMenu()
        {
            string choice = "";

            while(true)
            {
                Console.Clear();
                Console.WriteLine("1. Register Guest");
                Console.WriteLine("2. Back to Main Menu");
                Console.Write("Enter choice: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    RegisterGuest();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Returning to main menu...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }

                Console.WriteLine("Press any key to continue..");
                Console.ReadKey();
            }
        }
        public void RegisterGuest()
        {
            Console.Write("Enter Guest ID: ");
            string id = Console.ReadLine();

            if (guestService.SearchGuest(id) != null)
            {
                Console.WriteLine("This Guest ID already exists!");
                return;
            }

            Console.Write("Enter Guest Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Contact Number: ");
            string contact = Console.ReadLine();

            GuestModel guest = new GuestModel(id, name, contact);
            guestService.AddGuest(guest);
            Console.WriteLine("Guest registered.");

            bookingUI.BookRooms(id);
        }
        public void ShowAllGuests()
        {
            List<GuestModel> guests = guestService.GetAllGuests();

            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestId + "\t" + guest.GuestName + "\t\t" + guest.ContactNo);
            }
        }
        public void SearchGuest()
        {
            Console.Write("Enter Guest ID: ");
            string id = Console.ReadLine();

            GuestModel guest = guestService.SearchGuest(id);

            if (guest != null)
            {
                Console.WriteLine(guest.GuestId + "\t" + guest.GuestName + "\t\t" + guest.ContactNo);
            }
            else
            {
                Console.WriteLine("Guest not found.");
            }
        }
        public void UpdateGuest()
        {
            Console.Write("Enter Guest ID: ");
            string id = Console.ReadLine();

            GuestModel existingGuest = guestService.SearchGuest(id);

            if (existingGuest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }

            Console.Write("Enter new Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter new Contact Number: ");
            string contact = Console.ReadLine();

            GuestModel updatedGuest = new GuestModel(id, name, contact);
            guestService.UpdateGuest(updatedGuest);

            Console.WriteLine("Guest updated.");
        }

    }
}
