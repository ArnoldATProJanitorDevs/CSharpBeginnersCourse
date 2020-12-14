using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Example14___Gandolon_Revisited
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create needed instances
            Player player = new Player();
            Gandolon Gandolon = new Gandolon();

            // 2. Display Introduction screen
            Gandolon.DisplayIntroductionScreen();

            // 3. Make experience more humanoid
            Thread.Sleep(1000);

            // 4. Create new Poker-Deck, cards can be drawn from
            PokerDeck.GeneratePokerDeck();

            // 5. Display the 5 cards to select from
            Gandolon.DisplayCardsSelection();

            // 6. Display a call to action screen, player knows what to do next
            Gandolon.DisplayCallToActionScreen();

            // 7. Process player input to a number
            player.ProcessPlayerInput();

            // 8. Give the player a card and saves it into field "holdingCard"
            player.holdingCard = Gandolon.GivePlayerACard(player);

            // 9. Display the instruction for revealing the drawn card to the user
            Gandolon.DisplayChosenCardInstructionsScreen(player);

            // 10. Display the drawn card to the user
            Gandolon.RevealCardToPlayer(player.holdingCard);

            // 11. Make experience more humanoid
            Thread.Sleep(1000);

            // 12. Display the wait for player screen
            Gandolon.DisplayWaitForPlayerScreen();

            // 13. Display the simulation of a thinking Gandolon
            Gandolon.DisplayThinkingSimulationScreen();

            // 14. Display the final result screen
            Gandolon.DisplayGuessedCardScreen(player);

            // 15. Wait for the final answer of the player to end the game
            Gandolon.WaitForPlayerAndDisplayFinalAnswer();

        }
    }

    // I believe in you, that you can read this source code now and understand what is going one
    // since it is nothing else than already learned and handled before. (Except enum (aka enumeration))
    // Also many parts of the first program are just copied and restructured into classes with methods,
    // for the reusage in other programs or when extending this program!
    // If you truly need help, dont hesitate to contact me [CONTACT WEBSITE HERE]
    public class Gandolon
    {
        public void DisplayIntroductionScreen()
        {
            Console.WriteLine("_____________GANDOLON ARISES_____________");
            Console.WriteLine("Welcome my budding programmer.");
            Console.WriteLine("Be so kindly and draw one of the following cards:");
        }

        public void DisplayCardsSelection()
        {
            Console.WriteLine("_____ _____ _____ _____ _____ ");
            Console.WriteLine("|   | |   | |   | |   | |   | ");
            Console.WriteLine("| 1 | | 2 | | 3 | | 4 | | 5 | ");
            Console.WriteLine("|   | |   | |   | |   | |   | ");
            Console.WriteLine("¯¯¯¯¯ ¯¯¯¯¯ ¯¯¯¯¯ ¯¯¯¯¯ ¯¯¯¯¯ ");
        }
        public void DisplayCallToActionScreen()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter a number of 1 to 5 to choose a card. After that hit the enter key.");
        }

        public Card GivePlayerACard(Player player)
        {
            return PokerDeck.DrawCard();
        }

        public void DisplayChosenCardInstructionsScreen(Player player)
        {
            Console.WriteLine("You chose card number " + player.enteredNumber);
            Console.WriteLine("And this is your card, watch it good: ");
        }
        
        public void RevealCardToPlayer(Card card)
        {
            string[] lines = new string[5];

            lines[0] = "_____";
            lines[1] = "|" + this.GetSymbolForSuite(card.suite) + "  |";
            lines[2] = "| " + this.ConvertToNumberIfNoPictureCard(card.Rank) + " |";
            lines[3] = "|  " + this.GetSymbolForSuite(card.suite) + "|";
            lines[4] = "¯¯¯¯¯";

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }

        public void DisplayWaitForPlayerScreen()
        {
            Console.WriteLine("Hit Enter, when you are ready for my magic powers!");
            Console.ReadLine();

            Console.WriteLine("Now I am going to guess the card you have drawn:");
            Thread.Sleep(500);
            Console.WriteLine("Let me listen to your thoughts");
        }

        public void DisplayThinkingSimulationScreen()
        {
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(500 * i);
                Console.WriteLine("hmm...");
            }

            Thread.Sleep(1000);
            Console.WriteLine("AHA!");
            Thread.Sleep(1000);
        }

        public void DisplayGuessedCardScreen(Player player)
        {
            Console.WriteLine("Your card was:");
            RevealCardToPlayer(player.holdingCard);
        }

        public void WaitForPlayerAndDisplayFinalAnswer()
        {
            Console.WriteLine("Am I right? Enter Y for yes and N for no.");
            string answerOfUser = Console.ReadLine().Substring(0, 1).ToUpper();

            if (answerOfUser == "Y")
            {
                Console.WriteLine("I am the empowered Gandolon - Visionaire of the brains!");
            }
            else if (answerOfUser == "N")
            {
                Console.WriteLine("WHAT? It can't be, you are lying! Gandolon never misses a mindshot!");
            }
            else
            {
                Console.WriteLine("You cant fool me around giving false answers. This was the card you have drawn!");
            }
        }

        private string GetSymbolForSuite(Suite suite)
        {
            switch (suite)
            {
                case Suite.Clubs:
                    return "♣";
                case Suite.Diamonds:
                    return "♦";
                case Suite.Hearts:
                    return "♥";
                case Suite.Spades:
                    return "♠";
                default:
                    return "";
            }
        }
        private string ConvertToNumberIfNoPictureCard(Rank rank)
        {
            if ((int)rank > 0 && (int)rank < 11)
                return ((int)rank).ToString();
            else
                return rank.ToString().Substring(0, 1);
        }
    }

    public class Player
    {
        public Card holdingCard;

        public string playerInput;
        public int enteredNumber;

        public void ProcessPlayerInput()
        {
            this.playerInput = Console.ReadLine();
            this.enteredNumber = Convert.ToInt16(playerInput);
        }
    }

    public static class PokerDeck
    {
        public static List<Card> Cards = new List<Card>();

        public static void GeneratePokerDeck()
        {
            for (int a = 0; a < 4; a++)
            {
                for (int i = 0; i < 13; i++)
                {
                    Card newCard = new Card();
                    newCard.Rank = (Rank)i;
                    newCard.suite = (Suite)a;
                    Cards.Add(newCard);
                }
            }

            Cards.Exists((card) =>
            
                            (true)
            );
        }

        public static Card DrawCard()
        {
            if (Cards.Count <= 0)
                return null;

            int randomInteger = new Random().Next(Cards.Count);
            Card drawnCard = Cards[randomInteger];

            Cards.RemoveAt(randomInteger);

            return drawnCard;
        }
    }

    public class Card
    {
        public Suite suite;

        public Rank Rank;
        
    }

    public enum Suite
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades,
    }

    public enum Rank
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}
