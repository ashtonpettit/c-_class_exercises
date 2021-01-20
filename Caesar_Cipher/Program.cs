using System;
using System.Collections.Generic;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int shift = Convert.ToInt32(Console.ReadLine());
                if (shift < 0)
                {
                    shift = 26 + shift;
                }
                string input = Console.ReadLine();
                char[] word = input.ToCharArray();

                char[] alphabet = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                for (int i = 0; i < word.Length; i++)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (word[i] == alphabet[j])
                        {
                            word[i] = alphabet[(j + shift) % alphabet.Length];
                            break;
                        }
                    }
                }

                foreach (var item in word)
                {
                    Console.Write(item);
                }
            }
            
            catch (Exception)
            {
                Console.WriteLine("Crazy Input!");
            }

        }
    }
}
