using System;
using System.IO;

namespace fruit
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = File.OpenText("fruit.txt"); 
            string text = input.ReadToEnd();
            Console.Write(text);
            input.Close();
        }
    }
}
