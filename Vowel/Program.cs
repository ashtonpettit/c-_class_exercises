using System;

namespace Vowel
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = Convert.ToChar(Console.ReadLine());

            bool isVowel = "aeiou".IndexOf(input) >= 0;

            if (isVowel == true)
            {
                Console.WriteLine("Vowel");
            }
            else if (isVowel != true)
            {
                bool isNum = "1234567890".IndexOf(input) >= 0;

                if (isNum == true)
                {
                    Console.WriteLine("Number");
                }
                else
                {
                    Console.WriteLine("Consonant");
                }
            }

            

           
        }
    }
}
