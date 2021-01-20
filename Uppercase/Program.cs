using System;

namespace Uppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = Convert.ToChar(Console.ReadLine());

            bool isUpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(input) >= 0;

            if (isUpperCase == true)
            {
                Console.WriteLine("uppercase");
            }
            else
            {
                Console.WriteLine("lowercase");
            }
        }
    }
}
