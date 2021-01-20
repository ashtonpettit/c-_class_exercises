using System;
using System.Runtime.ExceptionServices;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            int a = (number / 2);
            int R1 = (number % 2);

            int b = (a / 2);
            int R2 = (a % 2);

            int c = (b / 2);
            int R3 = (b % 2);

            int d = (c / 2);
            int R4 = (c % 2);

            int e = (d / 2);
            int R5 = (d % 2);

            int f = (e / 2);
            int R6 = (e % 2);

            int g = (f / 2);
            int R7 = (f % 2);

            int h = (g / 2);
            int R8 = (g % 2);

            string b1 = Convert.ToString(R1);
            string b2 = Convert.ToString(R2);
            string b3 = Convert.ToString(R3);
            string b4 = Convert.ToString(R4);
            string b5 = Convert.ToString(R5);
            string b6 = Convert.ToString(R6);
            string b7 = Convert.ToString(R7);
            string b8 = Convert.ToString(R8);

            string binary = b8 + b7 + b6 + b5 + b4 + b3 + b2 + b1;

            Console.WriteLine(binary);
            




        }
    }
}
