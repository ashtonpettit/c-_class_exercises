using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            /*
            string decnum = Convert.ToInt32(input, 2).ToString();
            Console.WriteLine(decnum);
            */

            char[] c = input.ToCharArray();
            char[] binary = (char[])input.Reverse();
            foreach (char item in binary)
            {
                if (item == 1)
                {

                }
            }
        }
    }
}
