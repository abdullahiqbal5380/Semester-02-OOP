using HotelManagementSystem.Guest;
using HotelManagementSystem.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Booking
{
    public class BookingService
    {
        private readonly BookingRepository _repository;
        private readonly GuestService _guestService;
        private readonly RoomService _roomService;
        public BookingService()
        {
            _repository = new BookingRepository();
            _guestService = new GuestService();
            _roomService = new RoomService();
        }
        public List<BookingModel> GetAllBookings()
        {
            return _repository.LoadData();
        }

        public bool Booking(BookingModel booking)
        {
            // Check whether the guest exists
            GuestModel guest = _guestService.SearchGuest(booking.guestId);

            if (guest == null)
            {
                Console.WriteLine("Guest does not exist!");
                return false;
            }

            // Check the number of nights
            if (booking.Nights <= 0)
            {
                Console.WriteLine("Invalid number of nights!");
                return false;
            }

            // Save the booking
            _repository.SaveData(booking);
            return true;
        }

        public bool Checkout(string id)
        {
            if(_guestService.SearchGuest(id) == null)
            {
                return false;
            }

            List<BookingModel> bookings = _repository.LoadData();
           
            for (int i = 0; i < bookings.Count; i++)
            {
                if (bookings[i].guestId == id)
                {
                    bookings.RemoveAt(i);
                    i--;
                }
            }

            _repository.SaveAllBookings(bookings);
            _guestService.RemoveGuest(id);
            return true;
            
        }
        public bool isRoomBooked(int roomNumber)
        {
            List<BookingModel> bookings = _repository.LoadData();

            foreach (BookingModel booking in bookings)
            {
                if (booking.roomNumber == roomNumber)
                {
                    return true;
                }
            }

            return false;
        }
        public double CalculateRevenue()
        {
            List<BookingModel> bookings = _repository.LoadData();
            double revenue = 0;

            foreach (BookingModel booking in bookings)
            {
                RoomModel room = _roomService.SearchRoom(booking.roomNumber);

                if (room != null)
                {
                    revenue += booking.calculateBill(room.roomRate);
                }
            }
            return revenue;
        }
    }
}
