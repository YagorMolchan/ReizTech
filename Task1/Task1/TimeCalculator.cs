using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Exceptions;

namespace Task1
{
    public static class TimeCalculator
    {
        public const int MAX_MINUTE = 60;
        public const int MAX_HOUR = 12;

        public static float GetMinuteInDegrees(this int minute)
        {
            if(minute < 0 || minute > 59)
            {
                throw new MinuteException("The value of the minute must be inputted in the range from 0 to 59");
            }

            return (float)((minute * 2 * 180) / MAX_MINUTE);
        }

        public static float GetHourInDegrees(this int hour)
        {
            if(hour < 0 || hour > 23)
            {
                throw new MinuteException("The value of the hour must be inputted in the range from 0 to 23");
            }

            return (float)((hour * 2 * 180) / MAX_HOUR);
        }
    }
}
