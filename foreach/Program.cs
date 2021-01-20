using System;
using System.IO;
using System.Text.RegularExpressions;

namespace for_each
{
    class Program
{
    static void Main(string[] args)
    {
        StreamReader reader = File.OpenText("fruit.txt");

            char input = (char)Console.Read();

            string word = reader.ReadToEnd();

            Regex rx = new Regex(@"\b" + input + @"\b", RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(word);

            foreach (var matches in rx)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
