using System;
using System.Collections.Generic;


namespace secondLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            List<int> intList = new List<int>();

            foreach (int item in input)
            {
                if (!intList.Contains(item))
                {
                    intList.Add(item);
                }
            }

            int[] numbers = intList.ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            int num = numbers.Length - 2;

            Console.WriteLine(numbers[num]);
           
        }
    }
}
