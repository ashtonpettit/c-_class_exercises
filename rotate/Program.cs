using System;
using System.Collections.Generic;

namespace rotate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(5);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(5);

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in numbers)
            {
                if (item != 5)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
