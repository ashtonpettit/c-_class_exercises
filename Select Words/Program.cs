using System;
using System.Collections.Generic;
using System.IO;

namespace Select_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string fileName = Console.ReadLine();

                string lettersInput = Console.ReadLine();
                char[] letters = lettersInput.ToCharArray();

                int num = Convert.ToInt32(Console.ReadLine());
                int count = 0;

                List<string> wordList = new List<string>();

                StreamReader reader = File.OpenText(fileName);
                string line = reader.ReadLine();

                while (line != null)
                {
                    if (line.Length == num)
                    {
                        foreach (var letter in letters)
                        {
                            if (line.Contains(letter))
                            {
                                count++;
                            }
                        }
                        if (count >= letters.Length)
                        {
                            wordList.Add(line);
                        }
                    }
                    count = 0;
                    line = reader.ReadLine();
                }

                foreach (var item in wordList)
                {
                    Console.WriteLine(item);
                }

           
        }
    }
}
