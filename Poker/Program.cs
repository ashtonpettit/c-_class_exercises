using System;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] instructions = Console.ReadLine().Split(' ');
            Card myCard = new Card();

            myCard.AddCard("10h");

            Console.WriteLine(myCard.CardSuit);
            Console.WriteLine(myCard.CardValue);
            /*
            if(instructions.Length > 2)
            {
                for (int i = 2; i < instructions.Length; i++)
                {

                }
            } */
        }
    }
}
