using System;
using System.Globalization;

namespace Quarter
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = DateTime.Parse(Console.ReadLine());

            switch (date.Month)
            {
                case 1: 
                case 2: 
                case 3: Console.WriteLine(1); break;
                case 4: 
                case 5: 
                case 6: Console.WriteLine(2); break;
                case 7: 
                case 8: 
                case 9: Console.WriteLine(3); break;
                case 10: 
                case 11: 
                case 12: Console.WriteLine(4); break;
            }

        }
    }
}
