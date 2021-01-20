using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact;
            int input = Convert.ToInt32(Console.ReadLine());
            fact = input;

            if (input <= 1)
            {
                input = 1;
                Console.WriteLine(input);
            }
            else
            {
                for (int i = input - 1; i >= 1; i--)
                {
                    fact *= i;
                    
                }
                Console.WriteLine(fact);
            }
           
        }
    }
}
