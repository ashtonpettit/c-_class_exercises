using System;
using System.IO;
using System.Text.RegularExpressions;

namespace FindDobby
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StreamReader reader = File.OpenText("Harry Potter and the Sorcerer.txt");

            string text = reader.ReadToEnd();

            Regex rgx = new Regex(@input, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(text);
            Console.WriteLine(input + ": " + matches.Count + " occurrences");

            
        }
    }
}
