using System;
using System.Dynamic;


namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of cards you wish to draw:");
            string userInput = Console.ReadLine();
            int numberOfCards;  

            while(!int.TryParse(userInput, out numberOfCards) || numberOfCards < 0)
            {
                Console.WriteLine("Invalid input. Please try again");
                Console.WriteLine("Please enter the number of cards you wish to draw:");
                userInput = Console.ReadLine();
            }

            string[] hand = CardPicker.PickSomeCards(numberOfCards);

            foreach (string card in hand)
            {
                Console.WriteLine(card);
            }
        }
    }
}
