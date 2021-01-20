using System;
using System.Collections.Generic;

namespace practiceTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            List<int> aList = new List<int>();
            List<int> bList = new List<int>();
            List<int> final = new List<int>();

            int answer = 0;
            
            for (int i = a; i > 0; i--)
            {
                answer = a / i;
                if (a % i == 0) aList.Add(answer);
            }

            for (int j = b; j > 0; j--)
            {
                answer = b / j;
                if (b % j == 0) bList.Add(answer);
            }

            foreach (var item in aList)
            {
                foreach (var num in bList)
                {
                    if (item == num) final.Add(item);
                }
            }
            int[] finalArray = final.ToArray();

            Console.WriteLine(final[finalArray.Length - 1]);
            /*
            answer = 1;

            foreach (var item in aList)
            {
                answer = answer * item;
                if (answer <= a) final.Add(item);
            }
            answer = 1;
            foreach (var item in bList)
            {
                answer = answer * item;
                if (answer <= b) final.Add(item);
            }
            answer = 1;
            foreach (var item in final)
            {
                answer = answer * item;
            }

            Console.WriteLine(answer);
            */
            
        }

    }
}
