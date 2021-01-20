using System;
using System.Collections.Generic;

namespace Seperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nrs = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            for (int i = 0; i < nrs.Length; i++)
            {
                if (nrs[i] % 2 == 0)
                {
                    evens.Add(nrs[i]);
                }
                else
                {
                    odds.Add(nrs[i]);
                }
            }

            Console.Write("Even: ");
            foreach (var item in evens)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Odd: ");
            foreach (var item in odds)
            {
                Console.Write(item + " ");
            }
        }
    }
}
