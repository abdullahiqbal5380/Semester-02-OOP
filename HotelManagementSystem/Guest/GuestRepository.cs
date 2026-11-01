using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Guest
{
    public class GuestRepository
    {
        private readonly string _filePath = "C:\\Users\\wajid\\OneDrive\\Desktop\\Semester-2\\OOPS\\Week-06\\HotelManagementSystem\\Guest.txt";

        public List<GuestModel> LoadData()
        {
            List<GuestModel> guests = new List<GuestModel>();
            if (File.Exists(_filePath))
            {
                using(StreamReader sr = new StreamReader(_filePath))
                {
                    string record = "";
                    while((record = sr.ReadLine()) != null)
                    {
                        string[] data = record.Split(',');
                        GuestModel guest = new GuestModel(data[0], data[1], data[2]);
                        guests.Add(guest);
                    }
                }
            }
            return guests;
        }
        public void SaveData(GuestModel guest)
        {
            using(StreamWriter sw = new StreamWriter(_filePath, true))
            {
                sw.WriteLine(guest.ToString());
            }
        }
        public void SaveAllGuests(List<GuestModel> guests)
        {
            using(StreamWriter sw = new StreamWriter(_filePath, false))
            {
                foreach (GuestModel guest in guests)
                {
                    sw.WriteLine(guest.ToString());
                }
            }
        }
    }
}
