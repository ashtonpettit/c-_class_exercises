using System;
using System.Collections.Generic;

namespace DecimalToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            int decnum = Convert.ToInt32(Console.ReadLine());
            

            while (decnum > 9)
            {
                if (decnum >= 1000){ Console.Write("M") ; decnum = decnum - 1000; }
                if (decnum >= 500) { Console.Write("D"); decnum = decnum - 500;  }
                if (decnum >= 100) { Console.Write("C"); decnum = decnum - 100; }
                if (decnum >= 50) { Console.Write("L"); decnum = decnum - 50; }
                if (decnum >= 10) { Console.Write("X"); decnum = decnum - 10; }
            }

            while (decnum > 0)
            {
                if (decnum >= 5) { Console.Write("V"); decnum = decnum - 5; }
                if (decnum >= 1) { Console.Write("I"); decnum = decnum - 1; }
             }

            Console.WriteLine();

        }
    }
}
