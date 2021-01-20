using System;

namespace Celcius
{
    class Program
    {
        static void Main(string[] args)
        {
            double f = Convert.ToDouble(Console.ReadLine());

           double C = (f - 32);
            double c = (C * 5) / 9;

            Console.WriteLine(Math.Round(c, 2));


           

           

           
        }
    }
}
