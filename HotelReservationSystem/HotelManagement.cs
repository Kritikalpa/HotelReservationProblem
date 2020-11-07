using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelManagement
    {
        List<Hotel> hotelList = new List<Hotel>();

        public void addHotel()
        {
            hotelList.Add(new Hotel("Lakewood", 110));
            hotelList.Add(new Hotel("Bridgewood", 160));
            hotelList.Add(new Hotel("Ridgewood", 220));
            Console.WriteLine("Hotels are added");
        }
    }
}
