using HotelManagementSystem.Booking;
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
        public RoomUI()
        {
            _roomService = new RoomService();
            _bookingService = new BookingService();
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
    }
}
