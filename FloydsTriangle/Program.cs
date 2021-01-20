using System;
using System.Globalization;

namespace FloydsTriangle
{
    class Program
    {
        static void Main(string[] args)
        { 
            int lines = Convert.ToInt32(Console.ReadLine());
 
                int i, j, k = 1;
                for (i = 1; i <= lines; i++)
                {
                    for (j = 1; j < i + 1; j++)
                    {
                        Console.Write(k++ + " ");
                    }

                    Console.WriteLine();
                }
                
            }
        }


    }
       
