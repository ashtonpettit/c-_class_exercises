using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number of lines: ");
            string answer = Console.ReadLine();
            int nr;

            if (Int32.TryParse(answer, out nr))
            {

                Console.WriteLine("Enter a filename: ");
                string filename = Console.ReadLine();

                if (File.Exists(filename))
                {
                    StreamReader file = File.OpenText(filename);
                    for (int i = 0; i < nr; i++)
                    {
                        Console.WriteLine(file.ReadLine());
                    }
                    file.Close();
                }
                else
                {
                    Console.WriteLine("Give a correct filename!");
                }

            }
            else
            {
                Console.WriteLine("Give a correct number!");
            }
            

            StreamReader file = File.OpenText(filename);
            try
            {
                Console.WriteLine("Enter a number of lines: ");
                string answer = Console.ReadLine();
                int nr = Convert.ToInt32(answer);

                Console.WriteLine("Enter a filename: ");
                string filename = Console.ReadLine();

                
                for (int i = 0; i < nr; i++)
                {
                    Console.WriteLine(file.ReadLine());
                }
                file.Close();
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Oops! File was not found!");

            }
            catch (FormatException)
            {
                Console.WriteLine("Oops! Please insert a number!");
                
            }
            catch (OverflowException)
            {
                Console.WriteLine("Oops! Number was too big!");
            }
            catch (Exception exep)
            {
                Console.WriteLine("Oops! Something went wrong!");
                Console.WriteLine(exep.Message);
            }

            finally
            {
                file.Close();
                Console.WriteLine("Finally! We End!");
            }
            

            int strength = 0;
            try
            {
                Console.WriteLine("Give 3 Passwords: (seperated by a space)");
                string[] passwords = Console.ReadLine().Split(' ');
                for (int i = 0; i < 3; i++)
                {
                    Regex rgx = new Regex("^(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[!@#$%^&*()_+=]).{7,}$");
                    Match match = rgx.Match(passwords[i]);
                    if (match.Success)
                    {
                        strength++;
                    }
                }
                if (strength == 3)
                {
                    Console.WriteLine("All Passwords are Strong");
                }
                else
                {
                    Console.WriteLine("Passwords are Weak!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Please Input 3 Passwords!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
