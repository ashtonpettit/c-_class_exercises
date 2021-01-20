using Microsoft.VisualBasic;
using System;
using System.IO;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StreamReader reader = File.OpenText("english.txt");

            string word = reader.ReadLine();

            int line_nr = 1;

            while (word != null)
            {
                if (word.Contains(input))
                {
                    Console.WriteLine(line_nr);
                    break;
                } 
                
                word = reader.ReadLine();
                line_nr++;

            }

            if (line_nr > 194433)
            {
                Console.WriteLine("Not Found!");
            }


        }
    }
}
