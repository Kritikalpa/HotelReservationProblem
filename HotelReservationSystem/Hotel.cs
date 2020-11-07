using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Hotel
    {
        public string Name { get; set; }
        public int Rate { get; set; }

        public Hotel(string Name, int Rate)
        {
            this.Name = Name;
            this.Rate = Rate;
        }
    }
}
