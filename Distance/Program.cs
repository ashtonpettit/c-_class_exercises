using System;
using System.Xml;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
           string input1 = Console.ReadLine();
           int x = Convert.ToInt32(input1);

            string input2 = Console.ReadLine();
            int y = Convert.ToInt32(input2);

            string input3 = Console.ReadLine();
            int x2 = Convert.ToInt32(input3);

            string input4 = Console.ReadLine();
            int y2 = Convert.ToInt32(input4);

            int xLine = x2 - x;
            xLine = xLine * xLine;

            int yLine = y2 - y;
            yLine = yLine * yLine;

            int sqRt = xLine + yLine;

            double answer = Math.Sqrt(sqRt);

            int finalAnswer = (int)answer;

            Console.WriteLine(finalAnswer);




        }
    }
}
