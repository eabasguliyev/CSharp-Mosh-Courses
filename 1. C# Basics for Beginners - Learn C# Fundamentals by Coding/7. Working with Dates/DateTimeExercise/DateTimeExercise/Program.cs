using System;
using System.Globalization;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //var dateTime = DateTime.Now;

            //var shortDate = dateTime.ToShortDateString();
            //var completeDate = dateTime.ToShortDateString() + " " + dateTime.ToLongTimeString();
            //Console.WriteLine("Complete date: " + completeDate);
            //Console.WriteLine("Short date: " + shortDate);

            //DateTime dt1 = new DateTime(2021, 01, 15, 17, 23, 00);
            //Console.WriteLine("Complete date: " + dt1);

            //// Get date-only portion of date, without its time.

            //DateTime dateOnly = dt1.Date;

            //Console.WriteLine("Short date: " + dateOnly.ToString("d"));
            //Console.WriteLine("Display date using 24-hour clock format:");
            //Console.WriteLine(dateOnly.ToString("g"));
            //Console.WriteLine(dateOnly.ToString("dd/MM/yyyy HH:mm"));

            //2

            //DateTime now = DateTime.Now;


            //Console.WriteLine("Year = " + now.Year);
            //Console.WriteLine("Month = " + now.Month);
            //Console.WriteLine("Day = " + now.Day);
            //Console.WriteLine("Hour = " + now.Hour);
            //Console.WriteLine("Minute = " + now.Minute);
            //Console.WriteLine("Second = " + now.Second);
            //Console.WriteLine("Milliseconds = " + now.Millisecond);

            //DateTime now = DateTime.Now;

            //var dayOfWeek = now.DayOfWeek;

            //Console.WriteLine($"The day of the week for {now} is {dayOfWeek}");

            //3

            //Console.Write("First year: ");
            //var input1 = Console.ReadLine();
            //Console.Write("Second year: ");
            //var input2 = Console.ReadLine();

            //var dt1 = DateTime.Parse(input1);
            //var dt2 = DateTime.Parse(input2);

            //var totalYears = dt2.Year - dt1.Year;
            //for (int i = 0; i < totalYears; i++)
            //{
            //    DateTime dateToDisplay = dt1.AddYears(i);

            //    Console.WriteLine("{0:d}: day {1} of {2} {3}",
            //       dateToDisplay, dateToDisplay.DayOfYear, dateToDisplay.Year, DateTime.IsLeapYear((dateToDisplay.Year)) ? "(Leap Year)": "");
            //}

            // 5 Current date and time on the local computer


            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;

            String[] cultureNames = {"en-AZ", "en-IE", "en-ZA", "fr-CA", "de-CH", "ro-RO"};

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine(" Local Date and time: {0}, {1:G}", 
                    localDate.ToString(culture), localDate.Kind);
                Console.WriteLine(" UTC date and time: {0}, {1:G}", utcDate.ToString(culture), utcDate.Kind);
            }
        }
    }
}
