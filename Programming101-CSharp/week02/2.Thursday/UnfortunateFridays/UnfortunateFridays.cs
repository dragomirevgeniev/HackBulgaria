using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnfortunateFridays
{
    public class UnfortunateFridays
    {
        
        public static int CountUnfortunateFridays(int startYear, int endYear)
        {
            if (startYear > endYear)
            {
                int temp = endYear;
                endYear = startYear;
                startYear = temp;
            }

            DateTime date = new DateTime(startYear, 1 ,13);
            int counter = 0;

            while (date.Year <= endYear)
            {
                if (date.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    counter++;
                    Console.WriteLine(date.ToString("dd,MM,yyyyг.", new CultureInfo("bg-BG")));
                }

                date = date.AddMonths(1);
            }

            return counter;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter two years to find how many unfortunate fridays are in their range");
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Total: {0} unfortunate days", CountUnfortunateFridays(startYear, endYear));
        }
    }
}
