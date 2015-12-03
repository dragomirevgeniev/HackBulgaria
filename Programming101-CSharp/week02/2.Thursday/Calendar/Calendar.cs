using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calendar
{
    public class Calendar
    {
        public static void PrintCalendar(int month, int year, CultureInfo culture)
        {
            Thread.CurrentThread.CurrentCulture = culture;
            DateTime date = new DateTime(year, month, 01);
            DateTime dateForWeekDays = new DateTime(2015, 11, 02);
            string[] daysOfWeek = new string[7];
            Console.WriteLine("{0,30}", date.ToString("MMMM"));
            for (int i = 0; i < 7; i++)
            {
                Console.Write((dateForWeekDays).ToString("dddd "));
                daysOfWeek[i] = dateForWeekDays.ToString("dddd");
                dateForWeekDays = dateForWeekDays.AddDays(1);
            }

            Console.WriteLine();
            int indent = 0;
            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++ )
            {
                StringBuilder calendar = new StringBuilder();
                if (i == 1)
                {
                    int days = (int)date.DayOfWeek - 1;
                    if (days < 0)
                    {
                        days = 6;
                    }

                    for (int j = 0; j <= days; j++)
                    {
                        indent += daysOfWeek[j].Length + 1;
                    }

                    indent--;

                    if (date.DayOfWeek == 0)
                    {
                        calendar.Append(String.Format("{0," + indent + "}\n", i));
                    }

                    else
                    {
                        calendar.Append(String.Format("{0," + indent + "}", i));
                    }
                }

                else
                {
                    switch (date.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            calendar.Append(String.Format("{0," + daysOfWeek[0].Length + "}", i));
                            break;
                        case DayOfWeek.Tuesday:
                            calendar.Append(String.Format("{0," + (daysOfWeek[1].Length + 1) + "}", i));
                            break;
                        case DayOfWeek.Wednesday:
                            calendar.Append(String.Format("{0," + (daysOfWeek[2].Length + 1) + "}", i));
                            break;
                        case DayOfWeek.Thursday:
                            calendar.Append(String.Format("{0," + (daysOfWeek[3].Length + 1) + "}", i));
                            break;
                        case DayOfWeek.Friday:
                            calendar.Append(String.Format("{0," + (daysOfWeek[4].Length + 1) + "}", i));
                            break;
                        case DayOfWeek.Saturday:
                            calendar.Append(String.Format("{0," + (daysOfWeek[5].Length + 1) + "}", i));
                            break;
                        case DayOfWeek.Sunday:
                            calendar.Append(String.Format("{0," + (daysOfWeek[6].Length + 1) + "}\n", i));
                            break;
                        default:
                            break;
                    }
                }

                Console.Write(calendar);
                date = date.AddDays(1);
            }

            Console.WriteLine("\n");
        }

        public static void Main(string[] args)
        {
            PrintCalendar(02, 2015, new CultureInfo("bg-BG"));
        }
    }
}
