using System;

namespace OnlyEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] = numbers[i] + 1;
                }
            }

            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
