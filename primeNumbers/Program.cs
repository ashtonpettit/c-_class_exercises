using System;
using System.Collections.Generic;

namespace primeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] intArr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                double answer = 0;
                double sum = 0;
                int factor = 0;
                List<double> primes = new List<double>();
                bool isPrime = false;

                for (int i = 0; i < intArr.Length; i++)
                {
                    for (double j = intArr[i]; j > 0; j--)
                    {
                        answer = intArr[i] / j;
                        if (intArr[i] % j == 0)
                        {
                            factor++;
                        }
                    }
                    if (factor < 3) primes.Add(intArr[i]);
                    factor = 0;
                    answer = 0;
                }

                foreach (double item in primes)
                {
                    sum = sum + item;
                }
                Console.WriteLine(sum);
            }
            catch(Exception)
            {
                Console.WriteLine("crazy input");
            }
        }

    }
}
