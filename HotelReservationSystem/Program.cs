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
        }
    }
}
