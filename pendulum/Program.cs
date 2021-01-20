using System;
using System.Collections.Generic;

namespace pendulum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] letters = input.ToCharArray();
            List<char> halfWord = new List<char>();
           
            int degree = 0;

            if (letters.Length % 2 != 0)
            {
                for (int i = 0; i < (letters.Length / 2) + 1; i++)
                {
                    halfWord.Add(letters[i]);
                }
                halfWord.ToArray();
                int k = 0;
                for (int j = letters.Length / 2; j < letters.Length; j++)
                {
                    
                    if (halfWord[k] == letters[j])
                    {
                        degree++;
                    }
                    k++;
                }
                if (degree == 0)
                {
                    degree++;
                }
                Console.WriteLine(input + " is a Pendulum word. Degree: " + degree);
               
            }
            else
            {
                Console.WriteLine(input + " is not a pendulum word");
            }
        }
    }
}
