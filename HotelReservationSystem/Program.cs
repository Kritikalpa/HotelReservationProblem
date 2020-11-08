using System;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation program");

            HotelManagement hotelManagementNormal = new HotelManagement(CustomerType.NORMAL);
            hotelManagementNormal.addHotel();
            hotelManagementNormal.viewHotels();
            string cheapestHotel = hotelManagementNormal.findCheapestHotel();
            Console.WriteLine("Cheapest Hotel : " + cheapestHotel);
            hotelManagementNormal.findCheapTotalPrice();
            hotelManagementNormal.bestRatedHotelForDateRange();
            HotelManagement hotelManagementReward = new HotelManagement(CustomerType.REWARD);
            hotelManagementReward.addHotel();
            hotelManagementReward.viewHotels();
            hotelManagementReward.findCheapTotalPrice();
        }
    }
}
