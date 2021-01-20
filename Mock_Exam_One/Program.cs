using System;
using System.Collections.Generic;

namespace Mock_Exam_One
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Initalize the variables
                int num = Convert.ToInt32(Console.ReadLine()); //input 1
                int numTwo = Convert.ToInt32(Console.ReadLine()); //input 2
                int count = 0; //to compare the variables
                List<int> numList = new List<int>(); //to hold the divisible numbers for input 1
                List<int> numListTwo = new List<int>(); //to hold the divisible numbers for input 2


                //looping through the first number- using modulo to only store whole numbers (not 2.5 etc)
                for (int i = num - 1; i > 0; i--)
                {
                    int answer = num / i;
                    if (num % i == 0)
                    {
                        numList.Add(i);
                    }
                }

                //same as above but for the second input
                for (int j = numTwo - 1; j > 0; j--)
                {
                    int answer = numTwo / j;
                    if (numTwo % j == 0)
                    {
                        numListTwo.Add(j);
                    }
                }

                int finalAnswer = 0;
                int finalanswerTwo = 0;

                //a foreach loop to go through the first list of divisible numbers and add them together
                foreach (var item in numList)
                {
                    finalAnswer += item;
                }

                //same as before but for the second list
                foreach (var item in numListTwo)
                {
                    finalanswerTwo += item;
                }

                //comparing the added numbers of list one to input two, if a match then count++
                if (finalAnswer == numTwo)
                {
                    count++;
                }
                //same as above but for comparing the added numbers of list two with input one.
                if (finalanswerTwo == num)
                {
                    count++;
                }

                //if count is equal == 2, then the added numbers match the other input
                if (count == 2)
                {
                    Console.WriteLine(num + " and " + numTwo + " are good friends");
                }
                else
                {
                    Console.WriteLine(num + " and " + numTwo + " are not friends");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy Input");
            }
        }
    }
}
