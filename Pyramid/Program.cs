using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        
         {   /////////
            //   *   |
            //  * *  |
            // * * * |
            //* * * *|

            int lines = Convert.ToInt32(Console.ReadLine());
            int stars = lines;
            for (int i = lines; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                    
                }
                
                for (int j = stars; j >= lines; j--)
                {
                    Console.Write(" *");
                }
                lines--;
                Console.WriteLine();
            }
            

        }
    }
}
