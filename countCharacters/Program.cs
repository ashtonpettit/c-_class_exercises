using System;
using System.Text.RegularExpressions;

namespace countCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int vowels = Regex.Matches(input, @"[aeiouy]", RegexOptions.IgnoreCase).Count;

            int consonants = Regex.Matches(input, @"[a-z-[aeiouy]]", RegexOptions.IgnoreCase).Count;

            int other = Regex.Matches(input, @"[^a-z]", RegexOptions.IgnoreCase).Count;

            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants: " + consonants);
            Console.WriteLine("Other: " + other);


        }
    }
}
