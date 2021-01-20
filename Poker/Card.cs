using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    class Card
    {
        enum Suit
        {
            Clubs,
            Spades,
            Diamonds,
            Hearts
        }
        enum Value
        {
            Two = 2, Three, Four, Five, Six,
            Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
        }

        public int CardSuit;
        public int CardValue;
        public Card[] Hand;

        public Card()
        {

        }
        public Card(int cardsuit, int cardvalue)
        {
            CardSuit = cardsuit;
            CardValue = cardvalue;
        }

        public void AddCard(string card)
        {
            
        }

        public void GetCard(string card)
        {
            if (card.Contains("h"))
            {
                int value = (int)Enum.Parse(typeof(Suit), "Hearts");
                CardSuit = value;
            }
            if (card.Contains("d"))
            {
                int value = (int)Enum.Parse(typeof(Suit), "Diamonds");
                CardSuit = value;

            }
            if (card.Contains("s"))
            {
                int value = (int)Enum.Parse(typeof(Suit), "Spades");
                CardSuit = value;
            }
            if (card.Contains("c"))
            {
                int value = (int)Enum.Parse(typeof(Suit), "Clubs");
                CardSuit = value;
            }
            if (card.Contains("2"))
            {
                int value = (int)Enum.Parse(typeof(Value), "Two");
                CardValue = value;
            }
            if (card.Contains("3"))
            {
                int value = (int)Enum.Parse(typeof(Value), "Three");
                CardValue = value;
            }
            if (card.Contains("4"))
            {
                int value = (int)Enum.Parse(typeof(Value), "Four");
                CardValue = value;
            }
            if (card.Contains("5"))
            {
                int value = (int)Enum.Parse(typeof(Value), "Five");
                CardValue = value;
            }
            if (card.Contains("6"))
            {
                int value = (int)Enum.Parse(typeof(Value), "Six");
                CardValue = value;
            }
            if (card.Contains("7"))
            {
                int value = (int)Enum.Parse(typeof(Value), "Seven");
                CardValue = value;
            }
            if (card.Contains("8"))
            {
                int value = (int)Enum.Parse(typeof(Value), "Eight");
                CardValue = value;
            }
            if (card.Contains("9"))
            {
                int value = (int)Enum.Parse(typeof(Value), "Nine");
                CardValue = value;
            }
            if (card.Contains("10"))
            {
                int value = (int)Enum.Parse(typeof(Value), "Ten");
                CardValue = value;
            }
            if (card.Contains("J"))
            {
                int value = (int)Enum.Parse(typeof(Value), "Jack");
                CardValue = value;
            }
            if (card.Contains("Q"))
            {
                int value = (int)Enum.Parse(typeof(Value), "Queen");
                CardValue = value;
            }
            if (card.Contains("K"))
            {
                int value = (int)Enum.Parse(typeof(Value), "King");
                CardValue = value;
            }
            if (card.Contains("A"))
            {
                int value = (int)Enum.Parse(typeof(Value), "Ace");
                CardValue = value;
            }
        }
    }
}
