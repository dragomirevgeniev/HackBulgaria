using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentsIntersection
{
    public class AppointmentsIntersection
    {
        public static void FindIntersectingAppointments(DateTime[] startDates, TimeSpan[] durations)
        {
            if (startDates.Length != durations.Length)
            {
                Console.WriteLine("Error!");
                return;
            }
            
            for (int i = 0; i < startDates.Length; i++)
            {
                for (int j = i + 1; j < startDates.Length; j++)
                {
                    if (startDates[i] < startDates[j] && startDates[i] + durations[i] < startDates[j] + durations[j])
                    {
                        Console.WriteLine("The appointment starting at {0:dd/MM/yyyy hh:mm} intersects the appointment starting at {1:dd/MM/yyyy hh:mm} with exactly {2:F2} minutes.", 
                            startDates[i], startDates[j], (startDates[j] - startDates[i]).TotalMinutes);
                    }

                    else if (startDates[i] < startDates[j] && startDates[i] + durations[i] > startDates[j] + durations[j])
                    {
                        Console.WriteLine("The appointment starting at {0:dd/MM/yyyy hh:mm} intersects the appointment starting at {1:dd/MM/yyyy hh:mm} with exactly {2:F2} minutes.", 
                            startDates[i], startDates[j], ((startDates[j] + durations[j]) - startDates[j]).TotalMinutes);
                    }
                }
            }
        }
        
        public static void Main(string[] args)
        {
            DateTime[] appointments = {
                        new DateTime(2015, 07, 25, 15, 20, 00),
                        new DateTime(2015, 07, 25, 15, 25, 00),
                        new DateTime(2015, 07, 25, 15, 30, 00),
                        new DateTime(2015, 07, 25, 15, 40, 00),
                        new DateTime(2015, 07, 25, 15, 55, 00)
                    };

            TimeSpan[] durations = {
                        new TimeSpan(01, 00, 00),
                        new TimeSpan(01, 30, 00),
                        new TimeSpan(01, 20, 00),
                        new TimeSpan(02, 00, 00),
                        new TimeSpan(00, 30, 00)
                    };

            FindIntersectingAppointments(appointments, durations);
        }   
    }
}
