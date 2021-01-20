using System;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Files_Oct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a File ----> In the Debug Folder
            
            string filename = "file.txt";
            filename = @"C:\file.txt";
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filename = Path.Combine(folder, "file.txt");

            StreamWriter output = File.CreateText(filename);
            output.WriteLine("Some Text");
            output.Write("More Text");
            output.WriteLine("Even More Text");
            output.Close();

            if (File.Exists(filename))
            {
                StreamWriter output = (filename);

            } */

            //Reading from a file//

            Console.WriteLine("\n\n\nRead To End");
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            Console.WriteLine(text);
            input.Close();

            Console.WriteLine("\n\n\nRead Line by Line");
            input = File.OpenText("Rapunzel.txt");
            string line = input.ReadLine();
            while (line != null)
            {
                Console.WriteLine("LINE: " + line);
                line = input.ReadLine(); //read the next line to prevent infinite loop

            }
            input.Close();

            Console.WriteLine("\n\n\nRead Character by Character");
            input = File.OpenText("Rapunzel.txt");
            char c = (char)input.Read();
            while (!input.EndOfStream)
            {
                Console.Write(c + " ");
                c = (char)input.Read();
            }
            input.Close();

            Console.WriteLine("\n\n\nRead Character by Character --- FOR");
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text.ElementAt(i) + " ");
            }

            Console.WriteLine("\n\n\nRead Character by Character --- FOREACH");
            foreach (var item in text)
            {
                Console.Write(item + " ");
            }

            text = text.ToLower();
            Console.WriteLine("Length: " + text.Length);
            Console.WriteLine("First 10 of Text: " + text.Substring(0, 10));
            Console.WriteLine("Last 10 of Text: " + text.Substring(text.Length - 10, 10));
            Console.WriteLine("First Occurance: " + text.IndexOf("rapunzel"));
            Console.WriteLine("Last Occurance: " + text.LastIndexOf("rapunzel"));

            int count = 0;
            string word = "";
            foreach (char ch in text)
            {
                if ((ch >= 97) && (ch <= 122))
                {
                    word += ch;
                }
                else
                {
                    if (word == "rapunzel")
                    {
                        count++;
                    }
                    word = "";
                }
            }

            Regex rx = new Regex(@"Rapunzel", RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(text);
            Console.WriteLine(matches.Count + " matches found!");
            {

            }


            word = "";
            string abc = "abcdefghijklmnopqrstuvwxyz";
            foreach (char ch in text)
            {
                if (abc.Contains(ch))
                {
                    word += ch;
                }
                else
                {
                    if (word.Length == 9)
                    {
                        Console.Write(word);
                    }
                    word = "";
                }

                rx = new Regex(@"\b[a-z]{9}\b", RegexOptions.IgnoreCase);
                matches = rx.Matches(text);
                foreach (var item in matches)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}


