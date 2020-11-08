using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Hotel
    {
        public string Name { get; set; }
        public int WeekdayRate { get; set; }
        public int WeekendRate { get; set; }
        public int Rating { get; set; }


        public Hotel(string Name, int WeekdayRate, int WeekendRate, int Rating)
        {
            this.Name = Name;
            this.WeekdayRate = WeekdayRate;
            this.WeekendRate = WeekendRate;
            this.Rating = Rating;
        }
    }
}
