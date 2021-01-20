using System;

namespace pig_latin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] wordarr = input.Split(' ');
                
                foreach (var item in wordarr)
                {
                    char[] letter = item.ToCharArray();

                    char firstLetter = letter[0];
                    string lastLetter = firstLetter.ToString();

                    if (firstLetter == 'a' || firstLetter == 'e' || firstLetter == 'i' || firstLetter == 'o' || firstLetter == 'u' || firstLetter == 'y')
                    {
                        if(letter.Length == 1)
                        {
                            lastLetter = "way";
                            Console.Write(firstLetter + lastLetter + " ");
                        }
                        else
                        {
                            lastLetter = "way";
                            Console.Write(firstLetter);
                        }
                        
                    }
                    else if (firstLetter == '1' || firstLetter == '2'|| firstLetter == '3'|| firstLetter == '4'|| firstLetter == '5'|| firstLetter == '6'|| firstLetter == '7'|| firstLetter == '8'|| firstLetter == '9'|| firstLetter == '0')
                    {
                        Console.Write(firstLetter);
                    }
                    else
                    {
                        lastLetter = lastLetter + "ay";
                    }

                    for (int i = 1; i < letter.Length; i++)
                    {
                        
                        if (letter[i] == '1' || letter[i] == '2' || letter[i] == '3' || letter[i] == '4' || letter[i] == '5' || letter[i] == '6' || letter[i] == '7' || letter[i] == '8' || letter[i] == '9' || letter[i] == '0' || letter[i] == '.' )
                        {
                            Console.Write(letter[i]);
                        } 
                        else if (i == letter.Length - 1) 
                        {
                            Console.Write(letter[i] + lastLetter);
                        }
                        else
                        {
                            Console.Write(letter[i]);
                        }
                    }
                    Console.Write(" ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy Input!");
            }
            
        }
    }
}
