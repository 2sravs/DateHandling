using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + now);

            
            DateTime customDateTime = new DateTime(2023, 8, 3, 12, 30, 0);
            Console.WriteLine("Custom Date and Time: " + customDateTime);

           
            int year = now.Year;
            int month = now.Month;
            int day = now.Day;
            int hour = now.Hour;
            int minute = now.Minute;
            int second = now.Second;
            int dayOfWeek = (int)now.DayOfWeek;

            Console.WriteLine($"Year: {year}, Month: {month}, Day: {day}, Hour: {hour}, Minute: {minute}, Second: {second}, DayOfWeek: {dayOfWeek}");

            // Formatting dates
            string formattedDate1 = now.ToString("yyyy-MM-dd");
            string formattedDate2 = now.ToString("dd/MM/yyyy");
            string formattedDate3 = now.ToString("MMMM dd, yyyy");
            string formattedDate4 = now.ToString("dddd, MMMM dd, yyyy");
            string formattedTime1 = now.ToString("HH:mm:ss");
            string formattedTime2 = now.ToString("h:mm tt");

            Console.WriteLine("Formatted Date (yyyy-MM-dd): " + formattedDate1);
            Console.WriteLine("Formatted Date (dd/MM/yyyy): " + formattedDate2);
            Console.WriteLine("Formatted Date (MMMM dd, yyyy): " + formattedDate3);
            Console.WriteLine("Formatted Date (dddd, MMMM dd, yyyy): " + formattedDate4);
            Console.WriteLine("Formatted Time (HH:mm:ss): " + formattedTime1);
            Console.WriteLine("Formatted Time (h:mm tt): " + formattedTime2);

           
            DateTime futureDate = now.AddDays(7);
            TimeSpan timeDifference = futureDate - now;
            int daysDifference = timeDifference.Days;

            Console.WriteLine("Future Date (after 7 days): " + futureDate);
            Console.WriteLine($"Time Difference (days): {daysDifference}");
            Console.ReadKey();
        }
    }
}


