using System;

namespace Arrays_October
{
    class Program
    {
        static void Main(string[] args)
        {    /////////////////////////////
            //Creating and printing arrays
            //////////////////////////////
            
            string[] names = new string[4];

            names[0] = "Tuur";
            names[1] = "Jan";
            names[2] = "Mies";
            names[3] = "Bob";

            int[] ages = { 13, 10, 9, 7 };
            ages[1] = 11;

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " is " + ages[i] + " year's old.");
            }

            //////////////////////////////////////////////////////////////
            //Add items to array and print the array using loop structure
            //and adding items to array using user input
            //////////////////////////////////////////////////////////////
            
            Console.WriteLine("Number of students: ");
            int input = Convert.ToInt32(Console.ReadLine());
            string[] students = new string[input];

            for (int i = 0; i < students.Length; i++) //or use input for length
            {
                Console.Write("Student " + (i + 1) + ": ");
                students[i] = Console.ReadLine();
            }

            foreach (string item in students)
            {
                Console.WriteLine(item);
            }

            double[] grades = new double[input];
            for (int i = 0; i < input; i++)
            {
                Console.Write("Grade for" + students[i] + " : ");
                grades[i] = Convert.ToDouble(Console.ReadLine());
            }

            //////////////////////////////////////////////////////
            ///Take in input in one line and split it with space//
            //////////////////////////////////////////////////////
            
            Console.WriteLine("Give All Students (seperated by space)");
            students = Console.ReadLine().Split(' ');

            //Take input as string array then convert and put in int array
            Console.WriteLine("Give all lengths(seperated by semicolon)");
            string[] str_lengths = Console.ReadLine().Split(';');
            int[] lengths = new int[str_lengths.Length];
            for (int i = 0; i < str_lengths.Length; i++)
            {
                lengths[i] = Convert.ToInt32(str_lengths[i]);
            }

            foreach (var item in lengths)
            {
                Console.WriteLine(item);
            }

            //take input as int and convert immedietley
            Console.WriteLine("Give all lengths(seperated by semicolon)");
            int[] length = Array.ConvertAll(Console.ReadLine().Split(';'), Int32.Parse);
            
            
            int[] numbers = { 2, 7, 9, 1, 4 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j > numbers.Length - i - 1 ; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            foreach (var item in numbers)
            {
                Console.Write(item);
            }

            Array.Sort(numbers); //Array sort

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            
            ////////////////////////////////////////////////////////////
            ///2D Array to create a talbe                           ////
            ///////////////////////////////////////////////////////////
            int[,] table = new int[2, 4];
            Console.WriteLine("Nr of Elements inside table: " + table.Length);

            for (int i = 0; i < table.GetLength(0); i++) //rows
            {
                for (int j = 0; j < table.GetLength(1); j++) //colums
                {
                    Console.WriteLine("Element at " + i + " " + j + ": ");
                    table[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int i = 0; i < table.GetLength(0); i++) //rows
            {
                for (int j = 0; j < table.GetLength(1); j++) //colums
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }

            int sum = 0;
            foreach (var item in table)
            {
                sum += item; //sum = sum + item
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + sum/table.Length);
            

            ///////////////////////////////////////////////////////
            ///Jagged Array, inputing and printing a jagged array//
            ///////////////////////////////////////////////////////
            
            string[][] soccer = new string[3][];

            for (int i = 0; i < soccer.GetLength(0); i++)
            {
                Console.Write("Add Players on Row " + (i + 1 + "(seperated by space): "));
                soccer[i] = Console.ReadLine().Split(' ');
            }

            for (int i = 0; i < soccer.GetLength(0); i++)
            {
                for (int j = 0; j < soccer[i].Length; j++) //GET LENGTH OF ROW
                {
                    Console.Write(soccer[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
