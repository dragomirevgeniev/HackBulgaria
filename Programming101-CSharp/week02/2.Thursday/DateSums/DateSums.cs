using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSums
{
    public class DateSums
    {
        public static void PrintDatesWithGivenSum(int year, int sum)
        {
            DateTime date = new DateTime(year, 1, 1);
            int dateSum = 0;
            while (date.Year == year)
            {
                dateSum = 0;
                dateSum += (year % 10) + ((year / 10) % 10) + ((year / 100) % 10) + ((year / 1000) % 10);
                dateSum += (date.Day % 10) + ((date.Day / 10) % 10) + (date.Month % 10) + ((date.Month / 10) % 10);
                if (dateSum == sum)
                {
                    Console.WriteLine(date.ToString("dd,MM,yyyyг.", new CultureInfo("bg-BG")));
                }

                date = date.AddDays(1);
            }
        }
        
        public static void Main(string[] args)
        {
            PrintDatesWithGivenSum(2015, 13);
        }
    }
}
