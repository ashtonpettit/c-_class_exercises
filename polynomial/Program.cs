using System;
using System.Collections.Generic;

namespace polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int terms = Convert.ToInt32(Console.ReadLine());
                double x = Convert.ToDouble(Console.ReadLine());
                List<double> formula = new List<double>();
                double answer = 0;
                bool flag = false;

                for (double i = 1; i <= (terms * 2); i = i + 2)
                {
                    formula.Add(Math.Pow(x, i));
                }

                foreach (var item in formula)
                {
                    if (flag == false) answer = answer + item;
                    if (flag == true) answer = answer - item;

                    flag = !flag;
                }

                Console.WriteLine(Math.Round((answer), 2));
            }
            catch(Exception)
            {
                Console.WriteLine("Crazy Input!");
            }
        }
    }
}
