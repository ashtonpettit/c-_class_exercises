using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            double radius = Convert.ToDouble(input1);

            double C = 2 * 3.14159265359 * radius;
            double a = 3.14 * radius * radius;

            Console.WriteLine(Math.Round(C, 1));
            Console.WriteLine(Math.Ceiling(a * 10) / 10);
        }
    }
}
