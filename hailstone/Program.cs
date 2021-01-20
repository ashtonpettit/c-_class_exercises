using System;

namespace hailstone
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string number = Console.ReadLine();
                int num = Convert.ToInt32(number);

                while (num != 1)
                {
                    Console.WriteLine(num);

                    if (num % 2 == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        num = (3 * num) + 1;
                    }
                }
                Console.WriteLine(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Crazy Input!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Crazy Input!");
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy Input!");
            }
            
        }
    }
}
