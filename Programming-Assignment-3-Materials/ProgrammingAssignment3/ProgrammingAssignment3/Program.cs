using System;
using ConsoleCards;

namespace ProgrammingAssignment3
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programming Assignment 3
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK

                Deck deck = new Deck();


                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)

                Card player1card1 = deck.TakeTopCard();
                Card player2card1 = deck.TakeTopCard();
                Card player3card1 = deck.TakeTopCard();
                Card player4card1 = deck.TakeTopCard();
                Card player1card2 = deck.TakeTopCard();
                Card player2card2 = deck.TakeTopCard();
                Card player3card2 = deck.TakeTopCard();
                Card player4card2 = deck.TakeTopCard();


                // deal 1 more card to players 2 and 3
                Card player2card3 = deck.TakeTopCard();
                Card player3card3 = deck.TakeTopCard();

                // flip all the cards over
                player1card1.FlipOver();
                player2card1.FlipOver();
                player3card1.FlipOver();
                player4card1.FlipOver();
                player1card2.FlipOver();
                player2card2.FlipOver();
                player3card2.FlipOver();
                player4card2.FlipOver();
                player2card3.FlipOver();
                player3card3.FlipOver();

                // print the cards for player 1
                Console.WriteLine(player1card1.Rank + "," + player1card1.Suit);
                Console.WriteLine(player1card2.Rank + "," + player1card2.Suit);

                // print the cards for player 2
                Console.WriteLine(player2card1.Rank + "," + player2card1.Suit);
                Console.WriteLine(player2card2.Rank + "," + player2card2.Suit);
                Console.WriteLine(player2card3.Rank + "," + player2card3.Suit);

                // print the cards for player 3
                Console.WriteLine(player3card1.Rank + "," + player3card1.Suit);
                Console.WriteLine(player3card2.Rank + "," + player3card2.Suit);
                Console.WriteLine(player3card3.Rank + "," + player3card3.Suit);

                // print the cards for player 4
                Console.WriteLine(player4card1.Rank + "," + player4card1.Suit);
                Console.WriteLine(player4card2.Rank + "," + player4card2.Suit);

                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}
