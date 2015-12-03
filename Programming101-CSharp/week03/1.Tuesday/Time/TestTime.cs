using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    public class TestTime : Time
    {
        public static void Main(string[] args)
        {
            Time birthday = new Time(1995, 04, 15, 06, 30, 00);
            Console.WriteLine(birthday.ToString());
            Console.WriteLine(Time.Now());
            Console.WriteLine(DateTime.Now);
        }
    }
}
