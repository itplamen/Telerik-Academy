//11.Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class PrintAllCardsFromDeck
{
    static void Main(string[] args)
    {
        string[] cards = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
        string[] colors = { "Clubs", "Hearts", "Diamonds", "Spades" };

        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < colors.Length; j++)
            {
                Console.WriteLine("{0} of {1}", cards[i], colors[j]);
            }
        }
    }
}

