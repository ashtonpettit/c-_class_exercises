using System;
using System.IO;

namespace ReadtheLine
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter output = File.CreateText("test.txt");

            int nr_lines = Convert.ToInt32(Console.ReadLine());

            StreamReader reader = File.OpenText("Harry Potter and the Sorcerer.txt");

            string line = reader.ReadLine();

            for (int i = 0; i < nr_lines; i++)
            {
                output.WriteLine(i + ": " + line);
                line = reader.ReadLine();
            }

            output.Close();
            reader.Close();
        }
    }
}
