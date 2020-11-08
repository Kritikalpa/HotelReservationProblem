using System;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation program");

            HotelManagement hotelManagement = new HotelManagement();
            hotelManagement.addHotel();
            string cheapestHotel = hotelManagement.findCheapestHotel();
            Console.WriteLine("Cheapest Hotel : " + cheapestHotel);
            hotelManagement.findCheapTotalPrice();
            hotelManagement.bestRatedHotelForDateRange();
        }
    }
}
