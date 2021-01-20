using System;

namespace Roots
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int d = b * b - 4 * a * c;


            if (d > 0)
            {
                double d2 = Math.Sqrt(d);
                double a2 = 2 * a;
                double x1 = (-b + d2) / (a2);
                double x2 = (-b - d2) / (a2);


                Console.WriteLine(x1);
                Console.WriteLine(x2);
            } 
            else
            {
                Console.WriteLine("No Real Solutions");
            } 
              
            
        }
    }
}
