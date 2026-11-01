using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Guest
{
    public class GuestService
    {
        private readonly GuestRepository _guestRepository;
        public GuestService()
        {
            _guestRepository = new GuestRepository();
        }
        public List<GuestModel> GetAllGuests()
        {
            return _guestRepository.LoadData();
        }
        public void AddGuest(GuestModel guest)
        {
            _guestRepository.SaveData(guest);
        }
        public GuestModel SearchGuest(string id)
        {
            List<GuestModel> guests = _guestRepository.LoadData();
            foreach(GuestModel guest in guests)
            {
                if(guest.GuestId == id)
                {
                    return guest;
                }
            }
            return null;
        }
        public void UpdateGuest(GuestModel updateGuest)
        {
            List<GuestModel> guests = _guestRepository.LoadData();
            foreach (GuestModel guest in guests)
            {
                if (guest.GuestId == updateGuest.GuestId)
                {
                    guest.GuestName = updateGuest.GuestName;
                    guest.ContactNo = updateGuest.ContactNo;
                    break;
                }
            }
            _guestRepository.SaveAllGuests(guests);
        }
        public void RemoveGuest(string id)
        {
            List<GuestModel> guests = _guestRepository.LoadData();
            for (int i = 0; i < guests.Count; i++)
            {
                if (guests[i].GuestId == id)
                {
                    guests.RemoveAt(i);
                    break;
                }
            }
            _guestRepository.SaveAllGuests(guests);
        }
    }
}
