using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace ClockAngle
{
    public class ClockAngle
    {
        public static double GetClockHandsAngle(DateTime time, bool hourIsExact = true)
        {
            if (hourIsExact)
            {
                if (time.Hour >= 12)
                {
                    time = new DateTime(time.Year, time.Month, time.Day, time.Hour - 12, time.Minute, time.Second);
                }

                double hDegrees = time.Hour * 30;
                double mDegrees = time.Minute * 6;
                double angle = Math.Abs(hDegrees - mDegrees);
                
                return (angle < 180 ? angle : 360 - angle);
            }

            else
            {
                if (time.Hour >= 12)
                {
                    time = new DateTime(time.Year, time.Month, time.Day, time.Hour - 12, time.Minute, time.Second);
                }

                double hDegrees = (60 * time.Hour + time.Minute) * 0.5;
                double mDegrees = time.Minute * 6;
                double angle = Math.Abs(hDegrees - mDegrees);
                
                return (angle < 180 ? angle : 360 - angle);
            }
        }

        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            DateTime time = new DateTime(2015, 11, 29, 15, 30, 00);
            Console.WriteLine("Clock angle with exact hour calculation: {0:F2}°", GetClockHandsAngle(time));
            Console.WriteLine("Clock angle with non-exact hour calculation: {0:F2}°", GetClockHandsAngle(time, false));
        }
    }
}
