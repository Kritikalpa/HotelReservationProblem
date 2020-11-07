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
            hotelList.Add(new Hotel("Lakewood", 110, 90));
            hotelList.Add(new Hotel("Bridgewood", 160, 50));
            hotelList.Add(new Hotel("Ridgewood", 220, 150));
            Console.WriteLine("Hotels are added");
        }

        public string findCheapestHotel()
        {
            string hotelName = hotelList[1].Name;
            int rate = hotelList[1].WeekdayRate;
            hotelList.ForEach(hotel =>
            {
                if(hotel.WeekdayRate < rate)
                {
                    rate = hotel.WeekdayRate;
                    hotelName = hotel.Name;
                }
            });
            return hotelName;
        }
    }
}
