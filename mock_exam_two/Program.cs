using System;
using System.Collections.Generic;
using System.Linq;

namespace mock_exam_two
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                bool ispendulum = false;
                char[] word = input.ToCharArray();
                List<char> letterList = new List<char>();
                List<char> letterListTwo = new List<char>();
                int count = 0;
                if(input.Length % 2 != 0)
                {
                    for (int i = 0; i < (input.Length/2) + 1; i++)
                    {
                        letterList.Add(word[i]);
                    }

                    for (int i = input.Length / 2; i < input.Length; i++)
                    {
                        letterListTwo.Add(word[i]);
                    }
                }

                
                string halfword = "";
                int num = 0;
                foreach (var item in letterList)
                {
                    halfword += item;
                    num++;
                }

                string halfwordTwo = "";
                foreach (var item in letterListTwo)
                {
                    halfwordTwo += item;
                }

                if (halfword.Length == halfwordTwo.Length)
                {
                    ispendulum = true;
                }
                Console.WriteLine(halfword);
                Console.WriteLine(halfwordTwo);
                char[] wordone = halfwordTwo.ToCharArray();
                char[] wordtwo = halfword.ToCharArray();
                if (ispendulum == true)
                {
                    for (int i = 0; i < wordone.Length; i++)
                    {
                        if (wordone[i] == wordtwo[i])
                        {
                            count++;
                        }
                    }
                }
                if (count == 0) count++;

                if (ispendulum == true)
                {
                    Console.WriteLine(input + " is a pendulum word. Degree: " + count);
                }
                else
                {
                    Console.WriteLine(input + " is not a pendulum word.");
                } 
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
