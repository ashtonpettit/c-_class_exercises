using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {   
            //handle input
            int input = Convert.ToInt32(Console.ReadLine());
            int loopAmount = input - 2;

            //list to store answers including "0" and "1"
            List<string> results = new List<string>();
            results.Add("0");
            results.Add("1");

            //variables
            int result = 0;
            int num = 0;
            int num2 = 1;
            int loops = 0;

            //loop through variables and add result to string list
            while (loops <= loopAmount)
            {
                result = num + num2;
                num = num2;
                num2 = result;

                //convert int result to string and add to string list
                string myResult = result.ToString();
                results.Add(myResult);

                //increase loops to compare to loopAmount
                loops++;

            }

            foreach (var item in results)
            {
                Console.Write(item + " ");
            }

            int count = 0;

            for (count = 0; count <= 10; count++)
            {

                Console.WriteLine("Hello");

            }



        }
    }
}
