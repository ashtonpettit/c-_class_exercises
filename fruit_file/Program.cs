using System;
using System.IO;
using System.Text.RegularExpressions;

namespace fruit_file
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("fruit.txt");

            string input = Console.ReadLine();

            string text = reader.ReadToEnd();

            bool wordExists = false;

            Regex rx = new Regex(@"\b"+input+@"\b", RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(text);
            int word = matches.Count;

            if (word > 0)
            {
                wordExists = true;
                Console.WriteLine(wordExists);
            }
            else
            {
                Console.WriteLine(wordExists);
            }




        }
    }
}
