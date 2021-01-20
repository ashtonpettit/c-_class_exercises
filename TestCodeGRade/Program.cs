using System;

namespace TestCodeGRade
{
    class Program
    { /*
        input
        Elke
        1980
        output
        Hello Elke, you are 40 years old.

        input
        Jan
        2009
        output
        Hello Jan, you are 11 years old. */

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string birthYear = Console.ReadLine();
            int intbirthYear = Convert.ToInt32(birthYear);
            int age = DateTime.Now.Year - intbirthYear;
            Console.WriteLine("Hello {0}, you are {1} years old.", name, age);

            string nameTwo = Console.ReadLine();
            string birthYearTwo = Console.ReadLine();
            int intbirthYearTwo = Convert.ToInt32(birthYearTwo);
            int ageTwo = DateTime.Now.Year - intbirthYearTwo;
            Console.WriteLine("Hello {0}, you are {1} years old.", nameTwo, ageTwo);


        }
    }
}
