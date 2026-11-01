using HotelManagementSystem.Room;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Booking
{
    public class BookingRepository
    {
        private readonly string _filePath = "C:\\Users\\wajid\\OneDrive\\Desktop\\Semester-2\\OOPS\\Week-06\\HotelManagementSystem\\Booking.txt";

        public List<BookingModel> LoadData()
        {
            List<BookingModel> bookings = new List<BookingModel>();
            if (File.Exists(_filePath))
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string record = "";
                    while ((record = sr.ReadLine()) != null)
                    {
                        string[] data = record.Split(',');
                        BookingModel booking = new BookingModel(data[0], int.Parse(data[1]), int.Parse(data[2]));
                        bookings.Add(booking);
                    }
                }
            }
            return bookings;
        }
        public void SaveData(BookingModel booking)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                sw.WriteLine(booking.ToString());
            }
        }
        public void SaveAllBookings(List<BookingModel> bookings)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, false))
            {
                foreach (BookingModel booking in bookings)
                {
                    sw.WriteLine(booking.ToString());
                }
            }
        }
    }
}
