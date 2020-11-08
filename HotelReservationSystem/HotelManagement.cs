using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelManagement
    {
        CustomerType customerType;

        List<Hotel> hotelList = new List<Hotel>();

        public HotelManagement(CustomerType customerType)
        {
            this.customerType = customerType;
        }
        public void addHotel()
        {
            if (this.customerType.Equals(CustomerType.NORMAL))
            {
                hotelList.Add(new Hotel("Lakewood", 110, 90, 3));
                hotelList.Add(new Hotel("Bridgewood", 150, 50, 4));
                hotelList.Add(new Hotel("Ridgewood", 220, 150, 5));
            }
            else if (this.customerType.Equals(CustomerType.REWARD))
            {
                hotelList.Add(new Hotel("Lakewood", 80, 80, 3));
                hotelList.Add(new Hotel("Bridgewood", 110, 50, 4));
                hotelList.Add(new Hotel("Ridgewood", 100, 40, 5));
            }
            Console.WriteLine("Hotels are added");
        }

        public void viewHotels()
        {
            foreach(Hotel hotel in hotelList)
            {
                Console.WriteLine(hotel.toString());
            }
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
            Dictionary<Hotel, int> hotelToRateMap = new Dictionary<Hotel, int>();
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
                hotelToRateMap.Add(hotel, totalRate);
                totalRate = 0;
            }
            int lowestRate = hotelToRateMap.Min(x => x.Value);
            var cheapestHotels = hotelToRateMap.Where(x => x.Value == lowestRate);
            int highestRatingInCheapHotels = cheapestHotels.Max(x => x.Key.Rating);
            var hotels = cheapestHotels.Where(x => x.Key.Rating == highestRatingInCheapHotels);
            Console.WriteLine("Cheapest Hotels to stay in date range are : ");
            foreach(var hotel in hotels)
            {
                Console.WriteLine(hotel.Key.Name + ", Rating : " + hotel.Key.Rating + ", Total Price : " + hotel.Value);
            }
        }

        public void bestRatedHotelForDateRange()
        {
            var hotels = hotelList.Where(hotel => hotel.Rating == hotelList.Max(x => x.Rating));
            int totalRate = 0;
            Console.WriteLine("Enter the start date : ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end date : ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Highest Rated hotels and total Price for date range : ");
            foreach (Hotel hotel in hotels)
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
                Console.WriteLine(hotel.Name + ", Rating : " + hotel.Rating + ", Total Price : " + totalRate);
                totalRate = 0;
            }
        }
    }
}
