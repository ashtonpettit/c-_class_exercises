using System;
using System.Collections.Generic;

namespace Methods_Decembers
{
    class Program
    {
        void CountOccurences() {
            string sen = "count the occurence of every character!";

            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in sen)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else dic[c] = 1;

            }

            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }
        }

        static int[] numbers = { 4, 5, 6, 7, 8, 9, 0, 4, 2 };

        static void Print(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }

        static void Fill(ref int[] array)
        {
            
            Random rd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(-10, 101);
            }
            Print(array);
           
        }
        static void Main(string[] args)
        {
            
            int[] array = new int[10];
            Fill(ref array);
            Console.WriteLine();
            Print(array);
           // Program p = new Program();
           // p.CountOccurences();
            
            //Print(numbers);
           // Array.Sort(numbers);
          //  Print(numbers);

            //int[] nrs = Fill(100);
            //Print(nrs);


        }
    }
}
