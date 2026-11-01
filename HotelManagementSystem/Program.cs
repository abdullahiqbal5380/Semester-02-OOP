using HotelManagementSystem.Guest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelUI ui = new HotelUI();
            ui.MainMenu();
        }
    }
}
