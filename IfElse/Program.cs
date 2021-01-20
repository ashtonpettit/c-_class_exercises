using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Else If Conditionals */
            /*
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            if (password == "test123")
            {
                Console.WriteLine("Correct!");
            }
            else if (password == "123test")
            {
                Console.WriteLine("Correct!!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }


            // Combining Conditions//
            if ((password == "test123") || (password == "123test"))
            {
                Console.WriteLine("OK!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

            if ((password != "test123") && (password != "123test"))
            {
                Console.WriteLine("NO!");
            }
            else
            {
                Console.WriteLine("OK");
            }

            //Boolean
            bool condition = ((password == "test123") || (password == "123test"));
            if (condition) //Condition is true
            {
                Console.WriteLine("OK!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            if (!condition) //If condition is false
            {
                Console.WriteLine("NO!");
            }

            */

            Console.WriteLine("Age? ");
            string answer = Console.ReadLine();
            int age;
            bool success = Int32.TryParse(answer, out age);
            if (success)
            {
                if (age < 2)
                {
                    Console.WriteLine("Fresh Baby");
                }
                else if (age < 3)
                {
                    Console.WriteLine("Baby");

                }
                else if ((age > 2) && (age < 6)) // age < 6
                {

                    Console.WriteLine("Toddler");
                }
                else if ((age > 5) && (age < 10))
                {

                    Console.WriteLine("Child");
                }
                else if ((age > 9) && (age < 14))
                {

                    Console.WriteLine("Tween");
                }
                else if ((age > 13) && (age < 19))
                {

                    Console.WriteLine("Teenager");
                }
                else if (age > 17)
                {

                    Console.WriteLine("Adult");
                }
            }

            
        }
    }
}
