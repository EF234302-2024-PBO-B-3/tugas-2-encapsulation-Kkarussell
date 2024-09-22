using System;

namespace Encapsulation.Calendar
{
    public class Date
    {
        public int Month { get; private set; }
        public int Day { get; private set; }
        public int Year { get; private set; }

        public Date(int month, int day, int year)
        {
            if (month < 1 || month > 12)
                Month = 1;
            else
                Month = month;

            if (day < 1 || day > 31)
                Day = 1;
            else
                Day = day;

            Year = year >= 1970 ? year : 1970;
        }

        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}
