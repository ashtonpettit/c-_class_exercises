using System;

namespace _02Days_PF
{
    class Program
    {
        /*
        input
        113
        output
        0 year(s)
        16 week(s)
        1 day(s)

        input
        774
        output
        2 year(s)
        6 week(s)
        2 day(s)
        */

        static void Main(string[] args)
        {
            int year, months, week, day;
            int fullWeek = 7;
            int month = 30;

            string input = Console.ReadLine();
            int inputInt = Convert.ToInt32(input);
            year = inputInt / 365;
            month = inputInt / month;
            week = (inputInt % 365) / fullWeek;
            day = (inputInt % 365) % fullWeek;

            Console.WriteLine(year + "year(s)");
            Console.WriteLine(month + "month(s)");
            Console.WriteLine(week + "week(s)");
            Console.WriteLine(day + "day(s)");

            
            



        }
    }
}
