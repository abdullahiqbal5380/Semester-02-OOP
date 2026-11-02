using HotelManagementSystem.Booking;
using HotelManagementSystem.Guest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Room
{
    public class RoomUI
    {
        private readonly RoomService _roomService;
        private readonly BookingService _bookingService;
        private readonly GuestUI _guestUI;
        private readonly BookingUI _bookingUI;
        public RoomUI()
        {
            _roomService = new RoomService();
            _bookingService = new BookingService();
            _guestUI = new GuestUI();
            _bookingUI = new BookingUI();
        }
        public void ShowAllRooms()
        {
            List<RoomModel> rooms = _roomService.GetAllRooms();

            Console.WriteLine("Room No\tRoom Type\tRoom Rate");

            foreach (RoomModel room in rooms)
            {
                Console.WriteLine(room.roomNumber + "\t" + room.roomType + "\t\t" + room.roomRate);
            }
        }
        public void ShowRoomAvailability()
        {
            List<RoomModel> rooms = _roomService.GetAllRooms();

            Console.WriteLine("Room No\tRoom Type\tStatus");

            foreach (RoomModel room in rooms)
            {
                string status;

                if (_bookingService.isRoomBooked(room.roomNumber))
                {
                    status = "Booked";
                }
                else
                {
                    status = "Available";
                }

                Console.WriteLine(room.roomNumber + "\t" + room.roomType + "\t\t" + status);
            }
        }

        public void filterRecords()
        {
            _guestUI.Name();
            Console.WriteLine("Enter the minimum room number (101-200):");
            int minRoomNo = int.Parse(Console.ReadLine());
          
            Console.WriteLine("Enter the maximum room number (101-200):");
            int maxRoomNo = int.Parse(Console.ReadLine());

            _bookingUI.Status();
           
            List<RoomModel> rooms = _roomService.Rooms(minRoomNo, maxRoomNo);

            Console.WriteLine("Room No\tRoom Type\tRoom Rate");

            foreach (RoomModel room in rooms)
            {
                Console.WriteLine(room.roomNumber + "\t" + room.roomType + "\t\t" + room.roomRate);
            }
            
        }
    }
}
