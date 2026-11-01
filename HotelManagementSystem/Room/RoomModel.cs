using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Room
{
    public class RoomModel
    {
        public int roomNumber;
        public string roomType;
        public double roomRate;
        public RoomModel(int roomNo, string type, double rate)
        {
            roomNumber = roomNo;
            roomType = type;
            roomRate = rate;
        }
        public override string ToString()
        {
            return $"{roomNumber},{roomType},{roomRate}";
        }
    }
}
