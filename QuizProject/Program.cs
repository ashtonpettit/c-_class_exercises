using System;
using System.Collections.Generic;
using System.IO;

namespace QuizProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            int num = 1;
            List<int> userAnswers = new List<int>();

            StreamReader reader = File.OpenText("mockQuestions.txt");
            string question = reader.ReadLine();

            StreamReader readerTwo = File.OpenText("mockAnswers.txt");
            string answers = readerTwo.ReadLine();

            string[] questionsArr = File.ReadAllLines("mockQuestions.txt");

            string[] answersArr = answers.Split(',');

            for (int i = 0; i < questionsArr.Length; i++)
            {
                Console.WriteLine(questionsArr[i]);
                num = 1;
                foreach (var item in answersArr)
                {
                    Console.WriteLine(num + ". " + item);
                    num = num + 1;
                }
                Array.Clear(answersArr, 0, answersArr.Length);
                userAnswers.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Clear();
                
                answers = readerTwo.ReadLine();
                answersArr = answers.Split(',');

            }


        }
    }
}
