using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    class HotelException : Exception
    {
        public enum ExceptionType
        {
            INVALID_CUSTOMER_TYPE,
            INVALID_DATE
        }

        ExceptionType type;

        public HotelException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
