using System;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int x = Convert.ToInt32(input);



            if (x > 15)

            {

                if (x < 17)

                {

                    Console.Write("blue ");

                }

                else

                {

                    Console.Write("green ");

                }

                Console.WriteLine("jeans");

            }
        }
    }
}
