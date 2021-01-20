using System;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            bool leapYear = false;

            if (year % 4 != 0)
            {
                leapYear = false;
                Console.WriteLine(leapYear);
            }
            else if (year % 4 == 0)
            {
                if (year % 100 != 0)
                {
                    leapYear = true;
                    Console.WriteLine(leapYear);
                }
                else if (year % 100 == 0)
                {
                    if (year % 400 != 0)
                    {
                        leapYear = false;
                        Console.WriteLine(leapYear);
                    }
                    else if (year % 400 == 0)
                    {
                        leapYear = true;
                        Console.WriteLine(leapYear);
                    }
                }
            }
        }
    }
}
