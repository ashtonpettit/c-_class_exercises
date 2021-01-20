using System;
using System.Security.Cryptography.X509Certificates;

namespace Loops_14Oct
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("x? ");
            int x = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < 12; i++)
            {
                int result = i * x;
                Console.WriteLine(i + " * " + x + "=" + result);
            }
            // ---> 10
            for (int i = 12; i >= 0; i--)
            {
                int result = i * x;
                Console.WriteLine(i + " * " + x + "=" + result);
            }
            // ----> 10 by 2
            for (int i = 0; i < 12; i = i + 2)
            {
                int result = i * x;
                Console.WriteLine(i + " * " + x + "=" + result);
            } 

            
            for (int i = 0; i < 100; i = i + 3)
            {
                int result = i * x;
                Console.WriteLine(i + " * " + x + "=" + result);
            }

            for (int i = 0; i < 100; i +=3)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
            
            // Use F10 to execute code step by step-- useful for finding problems in loops.

            // Create a Table 
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(i + "-" + j + " ");
                }
                Console.WriteLine();
            }
            //*
            //**
            //***
            //****

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            
            //*****
            //****
            //***
            //**
            //*
            

            for (int i = 5; i >= 0; i--)
            {
                for (int j = 5; j <= i; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            //*****
            // ****
            //  ***
            //   **
            //    *
            int spaces = 0;
            for (int i = 5; i > 0; i--)
            {
                
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write("  ");
                }
                spaces++;
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            

            Console.Write("yes to continue: ");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                Console.Write("yes to continue: ");
                answer = Console.ReadLine();
            }
            

            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int result = (int)Math.Pow(x, i);
                Console.WriteLine(x + "^" + i + " = " + result);
            }

            int res_exp = x;
            do 
            {
                if ((x == 0) || (Math.Abs(x) == 1)) break;
                Console.Write(res_exp + " ");
                res_exp = res_exp * x;

            } while (res_exp < 1000000);











        }
    }
}
