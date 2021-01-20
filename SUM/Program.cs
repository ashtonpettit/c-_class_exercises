using System;

namespace SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            double input1 = Convert.ToDouble(firstInput);

            string secondInput = Console.ReadLine();
            double input2 = Convert.ToDouble(secondInput);

            string thirdInput = Console.ReadLine();
            double input3 = Convert.ToDouble(thirdInput);

            double answer = input1 + input2 + input3;

            int finalAnswer = Convert.ToInt32(answer);

            Console.WriteLine(finalAnswer);

        }
    }
}
