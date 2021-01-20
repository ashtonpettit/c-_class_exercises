using System;

namespace DigitasWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool ifNumber = "1234567890".IndexOf(input) >= 0;

            if (ifNumber == true)
            {
                int num = Convert.ToInt32(input);

                switch (num){
                    case 1: Console.WriteLine("One"); break;
                    case 2: Console.WriteLine("Two"); break;
                    case 3: Console.WriteLine("Three"); break;
                    case 4: Console.WriteLine("Four"); break;
                    case 5: Console.WriteLine("Five"); break;
                    case 6: Console.WriteLine("Six"); break;
                    case 7: Console.WriteLine("Seven"); break;
                    case 8: Console.WriteLine("Eight"); break;
                    case 9: Console.WriteLine("Nine"); break;
                    default : Console.WriteLine("Zero"); break;
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}
