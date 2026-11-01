using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Room
{
    public class RoomRepository
    {
        private readonly string _filePath = "C:\\Users\\wajid\\OneDrive\\Desktop\\Semester-2\\OOPS\\Week-06\\HotelManagementSystem\\Room.txt";

        public List<RoomModel> LoadData()
        {
            List<RoomModel> rooms = new List<RoomModel>();
            if (File.Exists(_filePath))
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string record = "";
                    while ((record = sr.ReadLine()) != null)
                    {
                        string[] data = record.Split(',');
                        RoomModel room = new RoomModel(int.Parse(data[0]), data[1], double.Parse(data[2]));
                        rooms.Add(room);
                    }
                }
            }
            return rooms;
        }
        public void SaveData(RoomModel room)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                sw.WriteLine(room.ToString());
            }
        }
        public void SaveAllRooms(List<RoomModel> rooms)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, false))
            {
                foreach (RoomModel room in rooms)
                {
                    sw.WriteLine(room.ToString());
                }
            }
        }
    }
}
