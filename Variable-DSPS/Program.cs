using System;

namespace Variable_DSPS
{
    class Program
    {
        static void Main(string[] args)
        { ///F10 to debug
            char a = 'a';
            int nr1, nr2;  ///declaring
            nr1 = 8;   ///initializing
            nr2 = 3;

            double b = 3.1;

            //++//

            nr1 = nr1 + 1;
            nr1++;

            nr1 = nr1 - 1;
            nr1--;

            Console.WriteLine(nr1);
            Console.WriteLine(nr1++);
            Console.WriteLine(nr1--);
            Console.WriteLine(++nr1);
            Console.WriteLine(--nr1);

            Console.WriteLine("+");
            Console.WriteLine(nr1 + b);
            Console.WriteLine("-");
            Console.WriteLine(nr1 - b);
            Console.WriteLine("/");
            Console.WriteLine(nr1 / b);
            Console.WriteLine("*");
            Console.WriteLine(nr1 * b);

            Console.WriteLine("%");
            Console.WriteLine(20 % 3);  ///modulo- what's left over/remainder
           /* remainder = 20 - (3 * results); */  // same thing as above

            Console.WriteLine("+");
            Console.WriteLine(20 + 2);
            Console.WriteLine(20 + "2");
            Console.WriteLine(20 + '2');   ///'2' is 50 on the ascci table.
            
            /*
            Console.WriteLine("Give your name");
            string name = Console.ReadLine();
            Console.WriteLine("Age: ");
            string answer = Console.ReadLine();
            int age = Convert.ToInt32(answer);

            int birthyear = 2020 - age;
            Console.WriteLine("hello " + name + " birthyear: " + birthyear);

            birthyear = DateTime.Now.Year - age;
            Console.WriteLine("Hello {0} birthyear: {1}", name, birthyear);
            */
            /*
            Console.Write("Character: ");
            char ch = Convert.ToChar(Console.ReadLine());*/
            /*
            int ascii = (int)ch;
            Console.WriteLine("Character {0} with ascii value {1}", ch, (int)ch);
            Console.WriteLine("Character {0} with ascii value {1}", ch, ascii);
            Console.WriteLine("Character {0} with ascii value {1}" + ascii);
            */

            
            Console.Write("Character: ");
            char ch = Convert.ToChar(Console.ReadLine());
          /*  char capCH = (char)(ascii - 32);*/

            int ascii = (int)ch;
            Console.WriteLine("Character {0} with ascii value {1}, captial {2}", ch, ascii, capCH);
            Console.WriteLine("Character {0} with ascii value {1}", ch, ascii);
            Console.WriteLine("Character {0} with ascii value {1}" + ascii);
            

            Console.Write("Character: ");
            /*
            int ascii = Console.Read(); */
        }
    }
}
