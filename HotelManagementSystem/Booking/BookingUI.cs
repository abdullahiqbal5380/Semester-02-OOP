using HotelManagementSystem.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Booking
{
    public class BookingUI
    {
        private readonly BookingService _service;
        private readonly RoomService _roomService;
        public BookingUI()
        {
            _service = new BookingService();
            _roomService = new RoomService();
        }

        public void BookRooms(string id)
        {
            Console.WriteLine("How many rooms do you want to book? ");
            int count = int.Parse(Console.ReadLine());

            if (count <= 0)
            {
                Console.WriteLine("Invalid number of rooms.");
                return;
            }

            int i = 0;

            while (i < count)
            {
                Console.WriteLine("----- Room " + (i + 1) + " -----");
                Console.WriteLine("1. Single - Rs. 7000");
                Console.WriteLine("2. Double - Rs. 10000");
                Console.WriteLine("3. Suite - Rs. 14000");
                Console.Write("Select room type: ");

                string choice = Console.ReadLine();
                string type = "";

                if (choice == "1")
                {
                    type = "Single";
                }
                else if (choice == "2")
                {
                    type = "Double";
                }
                else if (choice == "3")
                {
                    type = "Suite";
                }
                else
                {
                    Console.WriteLine("Invalid room type!");
                }

                if (type != "")
                {
                    List<RoomModel> rooms = _roomService.GetAllRooms();

                    Console.WriteLine("Available " + type + " Rooms:");

                    bool found = false;

                    foreach (RoomModel room in rooms)
                    {
                        if (room.roomType == type && !_service.isRoomBooked(room.roomNumber))
                        {
                            Console.WriteLine(room.roomNumber);
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("No available rooms of this type.");
                    }
                    else
                    {
                        Console.Write("Enter room number: ");
                        int roomNumber = int.Parse(Console.ReadLine());

                        RoomModel selectedRoom = _roomService.SearchRoom(roomNumber);

                        if (selectedRoom == null || selectedRoom.roomType != type)
                        {
                            Console.WriteLine("Invalid room number or room type!");
                        }
                        else
                        {
                            Console.Write("Enter number of nights: ");
                            int nights = int.Parse(Console.ReadLine());

                            BookingModel booking = new BookingModel(id, roomNumber, nights);

                            if (_service.Booking(booking))
                            {
                                Console.WriteLine("Room booked successfully.");
                                i++;
                            }
                            else
                            {
                                Console.WriteLine("Booking failed.");
                            }
                        }
                    }
                }
            }
        }
        public void CheckoutGuest()
        {
            Console.Write("Enter Guest ID for checkout: ");
            string guestID = Console.ReadLine();

            if (_service.Checkout(guestID))
            {
                Console.WriteLine("Guest checked-out Successfully!");
            }
            else
            {
                Console.WriteLine("Guest not found.");
            }
        }

        public void GenerateRevenueReport()
        {
            double revenue = _service.CalculateRevenue();

            Console.WriteLine("Total Revenue: " + revenue);
        }

        public void ShowAllBookings()
        {
            List<BookingModel> bookings = _service.GetAllBookings();

            Console.WriteLine("Guest ID\tRoom No\tNights");

            foreach (BookingModel booking in bookings)
            {
                Console.WriteLine(booking.guestId + "\t\t" + booking.roomNumber + "\t" + booking.Nights);
            }
        }

        public void Status()
        {
            Console.WriteLine("Enter the Status you want to check rooms (Booked or Available):");
            string status = Console.ReadLine();

            _service.filter(status);
           
        }
    }
}
