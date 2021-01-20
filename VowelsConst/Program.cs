using System;
using System.Collections.Generic;
using System.IO;

namespace VowelsConst
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filename = Console.ReadLine();

                StreamReader reader = File.OpenText(filename);

                List<char> vowels = new List<char>();
                List<char> cons = new List<char>();

                Dictionary<char, int> voweldict = new Dictionary<char, int>();

                string text = reader.ReadToEnd().ToLower();

                foreach (char c in text)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
                    {
                        vowels.Add(c);
                    }
                    else if (c == '.' || c == ' ' || c == ',') { }
                    else
                    {
                        cons.Add(c);
                    }
                }

                List<char> vowelLetter = new List<char>();
                int count = 0;
                Dictionary<char, int> dict = new Dictionary<char, int>();

                foreach (char c in vowels)
                {
                    if (!vowelLetter.Contains(c))
                    {
                        vowelLetter.Add(c);

                        foreach (char item in vowels)
                        {
                            if (c == item) count++;
                        }
                        dict.Add(c, count);
                    }
                    count = 0;
                }

                List<char> consLetter = new List<char>();
                count = 0;
                Dictionary<char, int> dictTwo = new Dictionary<char, int>();

                foreach (char c in cons)
                {
                    if (!consLetter.Contains(c))
                    {
                        consLetter.Add(c);

                        foreach (char item in cons)
                        {
                            if (c == item) count++;
                        }
                        dictTwo.Add(c, count);
                    }
                    count = 0;
                }

                KeyValuePair<char, int> max = new KeyValuePair<char, int>();

                foreach (KeyValuePair<char, int> item in dict)
                {
                    if (item.Value > max.Value)
                        max = item;
                }

                KeyValuePair<char, int> maxTwo = new KeyValuePair<char, int>();

                foreach (KeyValuePair<char, int> item in dictTwo)
                {
                    if (item.Value > maxTwo.Value)
                        maxTwo = item;
                }

                Console.WriteLine(max.Key + " " + maxTwo.Key);

            }
            catch(Exception)
            {
                Console.WriteLine("crazy input");
            }
            
        }
    }
}
