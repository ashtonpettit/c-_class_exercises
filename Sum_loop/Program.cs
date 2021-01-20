using System;

namespace Sum_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                int c = 0;
                for (int i = a + 1; i <= b; i = i + 2)
                {
                    c += i;
                }
                Console.WriteLine(c);
            }
            else
            {
                int c = 0;
                for (int i = a; i <= b; i = i + 2)
                {
                    c += i;
                }
                Console.WriteLine(c);
            }
        }
    }
}
