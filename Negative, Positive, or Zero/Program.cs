using System;

namespace Negative__Positive__or_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine("Negative");
            }
            else if (input > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
