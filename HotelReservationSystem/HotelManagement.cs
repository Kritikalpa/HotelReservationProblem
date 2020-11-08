using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelManagement
    {
        List<Hotel> hotelList = new List<Hotel>();

        public void addHotel()
        {
            hotelList.Add(new Hotel("Lakewood", 110, 90));
            hotelList.Add(new Hotel("Bridgewood", 150, 50));
            hotelList.Add(new Hotel("Ridgewood", 220, 150));
            Console.WriteLine("Hotels are added");
        }

        public string findCheapestHotel()
        {
            string hotelName = hotelList[1].Name;
            int rate = hotelList[1].WeekdayRate;
            hotelList.ForEach(hotel =>
            {
                if (hotel.WeekdayRate < rate)
                {
                    rate = hotel.WeekdayRate;
                    hotelName = hotel.Name;
                }
            });
            return hotelName;
        }

        public void findCheapTotalPrice()
        {
            Dictionary<string, int> hotelToRateMap = new Dictionary<string, int>();
            int totalRate = 0;
            Console.WriteLine("Enter the start date : ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end date : ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            foreach(Hotel hotel in hotelList)
            {
                for (DateTime i = startDate; i <= endDate;)
                {
                    if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                    {
                        totalRate += hotel.WeekendRate;
                    }
                    else
                    {
                        totalRate += hotel.WeekdayRate;
                    }
                    i = i.AddDays(1);
                }
                hotelToRateMap.Add(hotel.Name, totalRate);
                totalRate = 0;
            }
            int lowestRate = hotelToRateMap.Min(x => x.Value);
            var cheapestHotels = hotelToRateMap.Where(x => x.Value == lowestRate);
            Console.WriteLine("Cheapest Hotels to stay in date range are : ");
            foreach(var hotel in cheapestHotels)
            {
                Console.WriteLine(hotel.Key);
            }
        }
    }
}
