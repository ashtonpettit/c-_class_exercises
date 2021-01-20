using System;
using System.Text.RegularExpressions;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool pangram = false;

            Regex rgx = new Regex("(?i)^(?=.*a)(?=.*b)(?=.*c)(?=.*d)(?=.*e)(?=.*f)(?=.*g)(?=.*h)(?=.*i)(?=.*j)(?=.*k)(?=.*l)(?=.*m)(?=.*n)(?=.*o)(?=.*p)(?=.*q)(?=.*r)(?=.*s)(?=.*t)(?=.*u)(?=.*v)(?=.*w)(?=.*x)(?=.*y)(?=.*z).*$");
            Match matches = rgx.Match(input);

            if (matches.Success)
            {
                pangram = true;
                Console.WriteLine(pangram);
            }
            else
            {
                Console.WriteLine(pangram);
            }
        }
    }
}
