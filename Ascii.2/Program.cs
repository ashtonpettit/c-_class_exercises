using System;
using System.Reflection.PortableExecutable;

namespace Ascii
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            char character = Convert.ToChar(input);

            int _int = (int)character;
            int _int2 = _int - 1;

            char _char = (char)_int2;

            Console.WriteLine(_char);

        }
    }
}
