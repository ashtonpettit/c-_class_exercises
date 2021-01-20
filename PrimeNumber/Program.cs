using System;
using System.Collections.Generic;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //handle input//
            int num = Convert.ToInt32(Console.ReadLine());

            //initiate variables + lists
            List<int> myList = new List<int>(); 
            int factor = 0;
            double answer = 0;
            bool isPrime = false;    

            //Collect Factors and divided numbers
            for (double i = num; i > 0; i--)
            { 
                answer = num / i;
                if (num % i == 0)
                {
                    factor++;
                    int divided = Convert.ToInt32(answer);
                    myList.Add(divided);
                }
                
               
            }
            
            //if num has only 2 factors 
            if (factor < 3)
            {
                isPrime = true;
                Console.WriteLine(isPrime);
            }
            //if num has more than 2 factors
            else
            {
                Console.WriteLine(isPrime);
                foreach (int divided in myList)
                {
                    Console.Write(divided);
                }

            } 

           


        }
    }
}
