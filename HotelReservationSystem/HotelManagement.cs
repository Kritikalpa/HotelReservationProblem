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

        public string findCheapestHotel()
        {
            string hotelName = hotelList[1].Name;
            int rate = hotelList[1].Rate;
            hotelList.ForEach(hotel =>
            {
                if(hotel.Rate < rate)
                {
                    rate = hotel.Rate;
                    hotelName = hotel.Name;
                }
            });
            return hotelName;
        }
    }
}
