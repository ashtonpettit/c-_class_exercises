using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Find_the_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            

            Regex rgx = new Regex(@"\d+");
            Match[] matches = rgx.Matches(input).Cast<Match>().ToArray();

            

            string[] numbers = new string[matches.Length];

            for (int i = 0; i < matches.Length; i++)
            {
                numbers[i] = matches[i].ToString();
            }

            int[] nrs = Array.ConvertAll(numbers, Int32.Parse);

            for (int i = 0; i < nrs.Length; i++)
            {
                for (int j = 0; j < nrs.Length - i - 1; j++)
                {
                    if (nrs[j] > nrs[j + 1])
                    {
                        int temp = nrs[j];
                        nrs[j] = nrs[j + 1];
                        nrs[j + 1] = temp;
                    }
                }
            }

            foreach (int item in nrs)
            {
                Console.Write(item + " ");
            }


            

            
        }
    }
}
