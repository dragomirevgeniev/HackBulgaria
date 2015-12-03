using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    public class Time
    {
        private DateTime current;
        public Time() { }
        public Time(int year, int month, int day, int hour, int minute, int second)
        {
            this.current = new DateTime(year, month, day, hour, minute, second);
        }

        public override string ToString()
        {
            return this.current.ToString("hh:mm:ss dd.MM.yy");
        }

        public static Time Now()
        {
            DateTime current = DateTime.Now;
            return new Time(current.Year, current.Month, current.Day, current.Hour, current.Minute, current.Second);
        }
    }
}
