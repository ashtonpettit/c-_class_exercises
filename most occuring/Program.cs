using System;

namespace most_occuring
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = Console.ReadLine().Split();

            int count = 0;
            int oldCount = 0;

            string word = "";
            string oldWord = "";

            for (int i = 0; i < fruits.Length; i++)
            {
                word = fruits[i];
                count = 0;
                for (int j = 0; j < fruits.Length; j++)
                {
                    if (fruits[j].Contains(word))
                    {
                        count++;
                    }
                }
                if (count > oldCount)
                {
                    oldCount = count;
                    oldWord = word;
                }
             
            }

            int finalCount = Math.Max(count, oldCount);
            if (finalCount == count)
            {
                Console.WriteLine(word);
            }
            else if (finalCount == oldCount)
            {
                Console.WriteLine(oldWord);
            }
        }
    }
    }

