using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Booking
{
    public class BookingModel
    {
        public string guestId;
        public int roomNumber;
        public int Nights;
        public BookingModel(string id, int roomNo, int nights)
        {
            guestId = id;
            roomNumber = roomNo;
            Nights = nights;
        }
        public double calculateBill(double roomRate)
        {
            return roomRate * Nights;
        }
        public override string ToString()
        {
            return $"{guestId},{roomNumber},{Nights}";
         
        }
    }
}
