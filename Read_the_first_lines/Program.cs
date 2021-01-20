using System;
using System.IO;
using System.Text;

namespace Read_the_first_lines
{
    class Program
    {
        static void Main(string[] args)
        {

            int nr_lines = Convert.ToInt32(Console.ReadLine());

            StreamWriter output = File.CreateText("harry-" + nr_lines + ".txt");

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
