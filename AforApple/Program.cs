using System;
using System.IO;
using System.Text.RegularExpressions;

namespace AforApple
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("fruit.txt");

           /* char input = (char)Console.Read();
            int matches = 0;

            string word = reader.ReadLine();

            while (word != null)
            {
                if (word.Contains(input))
                {
                    matches++;
                    Console.WriteLine(word);
                }
 
                word = reader.ReadLine();
            }

            if(matches == 0)
            {
                Console.WriteLine("Nothing Found");
            }

            */

            StreamReader input = File.OpenText("fruit.txt");
            string line = input.ReadLine();
            char character = Convert.ToChar(Console.ReadLine());
            while (line != null)
            {
                    if (line.Contains(character))
                    {
                        Console.WriteLine(line);
                    }
                
                line = input.ReadLine();
            }
            input.Close();
        }
    }
}
