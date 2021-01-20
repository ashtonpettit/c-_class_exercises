using System;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            int vowels = 0;
            
            int sentence = input.Length;
            
            for (int i = 0; i < sentence; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'y')
                {
                    vowels++;
                }
            }
            Console.WriteLine(vowels);
 
            }
        }
    }

