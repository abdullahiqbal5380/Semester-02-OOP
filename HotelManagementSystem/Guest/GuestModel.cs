using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class GuestModel
    {
        public string GuestId;
        public string GuestName;
        public string ContactNo;

        public GuestModel(string guestId, string guestName, string contact)
        {
            GuestId = guestId;
            GuestName = guestName;
            ContactNo = contact;
        }
        public override string ToString()
        {
            return $"{GuestId},{GuestName},{ContactNo}";
        }
    }
}
