using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Room
{
    public class RoomService
    {
        private readonly RoomRepository _roomRepository;
        public RoomService()
        {
            _roomRepository = new RoomRepository();
        }
        public List<RoomModel> GetAllRooms()
        {
            return _roomRepository.LoadData();
        }

        public RoomModel SearchRoom(int roomNumber)
        {
            List<RoomModel> rooms = _roomRepository.LoadData();

            foreach (RoomModel room in rooms)
            {
                if (room.roomNumber == roomNumber)
                {
                    return room;
                }
            }

            return null;
        }

        public List<RoomModel> Rooms(int minroom, int maxroom)
        {
            List<RoomModel> rooms = _roomRepository.LoadData();
            List<RoomModel> Room = new List<RoomModel>();

            foreach(RoomModel room in rooms)
            {
                if (room.roomNumber >= minroom && room.roomNumber <= maxroom)
                {
                    Room.Add(room);
                }
            }
            return Room;
        }
    }

}
