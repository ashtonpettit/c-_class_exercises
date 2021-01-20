using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int result = Math.Max(Math.Max(num1, num2), num3);

            Console.WriteLine(result);

        }
    }
}
