using System;

namespace Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string fruitsInput = Console.ReadLine();

            string[] fruits = fruitsInput.Split();

            int count = 0;
            foreach (var item in fruits)
            {
                if (item.Contains(input))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
