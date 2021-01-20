using System;
using System.Linq;

namespace Greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());

            double max3 = Math.Max(A, Math.Max(B, C));

            Console.WriteLine(max3);



            
        }
    }
}
