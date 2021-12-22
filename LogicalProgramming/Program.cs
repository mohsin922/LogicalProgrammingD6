using System;
using System.Collections.Generic;


namespace LogicalProgramming
{
    class GregorianCalendar
    {
        public static void Dayofweek(int d, int m, int y)
        {
            List<string> day = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            int y0, x, m0, d0;
            y0 = y - (14 - m) / 12;
            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = m + 12 * ((14 - m) / 12) - 2;
            d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine("week day of entered date is {0}", day[d0]);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter day : ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter month: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter year: ");
            int y = Convert.ToInt32(Console.ReadLine());


            GregorianCalendar.Dayofweek(d, m, y);
        }
    }
}
