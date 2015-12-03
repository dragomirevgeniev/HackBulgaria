using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1337
{
    public class Program
    {
        public static void HackerTime()
        {
            DateTime special = new DateTime(DateTime.Now.Year, 12, 21, 13, 37, 0);
            TimeSpan span = new TimeSpan();
            span = special - DateTime.Now; 

            if (span < TimeSpan.Zero)
            {
                DateTime newSpecialDate = new DateTime(DateTime.Now.Year + 1, 12, 21, 13, 37, 0);
                span = newSpecialDate - DateTime.Now;
            }

            Console.WriteLine("{0}:{1}:{2}", span.Days, span.Hours, span.Minutes);
        }

        public static void Main(string[] args)
        {
            HackerTime();
        }
    }
}
