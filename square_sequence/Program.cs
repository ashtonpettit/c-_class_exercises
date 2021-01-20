using System;
using System.Collections.Generic;

namespace square_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                int answer = 0;

                List<int> intList = new List<int>();

                for (int i = 1; i <= num; i++)
                {
                    answer = i * i;
                    intList.Add(answer);
                }
                answer = 0;
                foreach (var item in intList)
                {
                    Console.Write(item + " ");
                    answer = answer + item;
                }
                Console.WriteLine();
                Console.WriteLine("Sum =" + answer);

            }
            catch(Exception)
            { 
                Console.WriteLine("Crazy Input!"); 
            }
            
        }
    }
}
