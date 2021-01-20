using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double input1 = Convert.ToDouble(Console.ReadLine());
            double input2 = Convert.ToDouble(Console.ReadLine());
            double input3 = Convert.ToDouble(Console.ReadLine());
            double input4 = Convert.ToDouble(Console.ReadLine());
            double input5 = Convert.ToDouble(Console.ReadLine());

            double average = (input1 + input2 + input3 + input4 + input5) / 5;

            if (average >= 9)
            {
                Console.WriteLine("A");
            }
            else if (average >= 8)
            {
                Console.WriteLine("B");
            }
            else if (average >= 7)
            {
                Console.WriteLine("C");
            }
            else if (average >= 6)
            {
                Console.WriteLine("D");
            }
            else if (average >= 4)
            {
                Console.WriteLine("E");
            }
            else if (average < 4)
            {
                Console.WriteLine("F");
            }
;        }
    }
}
