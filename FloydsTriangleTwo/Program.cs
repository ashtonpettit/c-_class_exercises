using System;

namespace FloydsTriangleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int lines = Convert.ToInt32(Console.ReadLine());
                int number = lines;
                int i, j, k, l;
                k = 1;

                for (i = lines; i > 0; i--)
                {
                    for (j = 1; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            k = 1;
                        }
                        else
                        {
                            k = 0;
                        }

                        Console.Write(" ");

                    }

                    for (l = number; l >= lines; l--)
                    {
                        if (k == 0)
                        {
                            k++;
                        }
                        else if (k == 1)
                        {
                            k--;
                        }

                        Console.Write(" " + k);
                    }

                    lines--;
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy Input!");
            }
        }
    }
}
