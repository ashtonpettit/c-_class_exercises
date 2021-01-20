using System;

namespace Harmonica
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                double result = 0;
                string[] factions = new string[Convert.ToInt32(num)];

                for (double i = 1; i <= num; i++)
                {

                    factions[Convert.ToInt32(i) - 1] = ("1 / " + i);
                    result = result + (1 / i);
                }

                result = Math.Round((result), 4);

                Console.Write(result + "(= ");

                for (int j = 0; j < factions.Length; j++)
                {
                    if (j == num - 1)
                    {
                        Console.Write(factions[j]);
                    }
                    else
                    {
                        Console.Write(factions[j] + " + ");
                    }


                }
                Console.Write(")");

            }
            catch (Exception)
            {
                Console.WriteLine("crazy Input!");
            }
        }
    }
}
