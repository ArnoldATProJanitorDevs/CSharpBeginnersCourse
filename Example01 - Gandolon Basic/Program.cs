using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //Welcome Screen
        Console.WriteLine("_____________GANDOLON ARISES_____________");
        Console.WriteLine("Welcome my budding programmer.");
        Console.WriteLine("Be so kindly and draw one of the following cards:");
        Console.WriteLine("_____ _____ _____ _____ _____ ");
        Console.WriteLine("|   | |   | |   | |   | |   | ");
        Console.WriteLine("| 1 | | 2 | | 3 | | 4 | | 5 | ");
        Console.WriteLine("|   | |   | |   | |   | |   | ");
        Console.WriteLine("¯¯¯¯¯ ¯¯¯¯¯ ¯¯¯¯¯ ¯¯¯¯¯ ¯¯¯¯¯ ");
        Console.WriteLine("");
        Console.WriteLine("Enter a number of 1 to 5 to choose a card. After that hit the enter key.");

        //User has to answer
        var userInput = Console.ReadLine();
        int enteredNumber = Convert.ToInt32(userInput);

        //Gandolons Answer#1
        Console.WriteLine("You chose card number " + enteredNumber);
        
        //Displaying the Card to the User
        Console.WriteLine("And this is your card, watch it good: ");
        if (enteredNumber == 1)
        {
            Console.WriteLine("_____ ");
            Console.WriteLine("|♥  | ");
            Console.WriteLine("| A | ");
            Console.WriteLine("|  ♥| ");
            Console.WriteLine("¯¯¯¯¯ ");
        }
        else if (enteredNumber == 2)
        {
            Console.WriteLine("_____ ");
            Console.WriteLine("|♠  | ");
            Console.WriteLine("| J | ");
            Console.WriteLine("|  ♠| ");
            Console.WriteLine("¯¯¯¯¯ ");
        }
        else if (enteredNumber == 3)
        {
            Console.WriteLine("_____ ");
            Console.WriteLine("|♣  | ");
            Console.WriteLine("| K | ");
            Console.WriteLine("|  ♣| ");
            Console.WriteLine("¯¯¯¯¯ ");
        }
        else if (enteredNumber == 4)
        {
            Console.WriteLine("_____ ");
            Console.WriteLine("|♣  | ");
            Console.WriteLine("| A | ");
            Console.WriteLine("|  ♣| ");
            Console.WriteLine("¯¯¯¯¯ ");
        }
        else if (enteredNumber == 5)
        {
            Console.WriteLine("_____ ");
            Console.WriteLine("|♣  | ");
            Console.WriteLine("| 7 | ");
            Console.WriteLine("|  ♣| ");
            Console.WriteLine("¯¯¯¯¯ ");
        }
        else
        {
            Console.WriteLine("Ha ha ha! Don't fool me, Here is a card then.");
            Console.WriteLine("_____ ");
            Console.WriteLine("|♦  | ");
            Console.WriteLine("| Q | ");
            Console.WriteLine("|  ♦| ");
            Console.WriteLine("¯¯¯¯¯ ");
        }

        //Let the user memorize the card
        Thread.Sleep(1000);

        //Wait for user Input
        Console.WriteLine("Hit Enter, when you are ready for my magic powers!");
        Console.ReadLine();

        //Gandolons Answer#2
        Console.WriteLine("Now I am going to guess the card you have drawn:");
        Thread.Sleep(500);
        Console.WriteLine("Let me listen to your thoughts");

        //Gandolon's thinking
        for (int i = 0; i < 4; i++)
        {
            Thread.Sleep(500 * i);
            Console.WriteLine("hmm...");
        }

        //Tension for the user
        Thread.Sleep(1000);
        Console.WriteLine("AHA!");
        Thread.Sleep(1000);

        //Gandolon Reveals the card you have dran
        Console.WriteLine("Your card was:");
        if (enteredNumber == 1)
        {
            Console.WriteLine("_____ ");
            Console.WriteLine("|♥  | ");
            Console.WriteLine("| A | ");
            Console.WriteLine("|  ♥| ");
            Console.WriteLine("¯¯¯¯¯ ");
        }
        else if (enteredNumber == 2)
        {
            Console.WriteLine("_____ ");
            Console.WriteLine("|♠  | ");
            Console.WriteLine("| J | ");
            Console.WriteLine("|  ♠| ");
            Console.WriteLine("¯¯¯¯¯ ");
        }
        else if (enteredNumber == 3)
        {
            Console.WriteLine("_____ ");
            Console.WriteLine("|♣  | ");
            Console.WriteLine("| K | ");
            Console.WriteLine("|  ♣| ");
            Console.WriteLine("¯¯¯¯¯ ");
        }
        else if (enteredNumber == 4)
        {
            Console.WriteLine("_____ ");
            Console.WriteLine("|♣  | ");
            Console.WriteLine("| A | ");
            Console.WriteLine("|  ♣| ");
            Console.WriteLine("¯¯¯¯¯ ");
        }
        else if (enteredNumber == 5)
        {
            Console.WriteLine("_____ ");
            Console.WriteLine("|♣  | ");
            Console.WriteLine("| 7 | ");
            Console.WriteLine("|  ♣| ");
            Console.WriteLine("¯¯¯¯¯ ");
        }
        else
        {
            Console.WriteLine("_____ ");
            Console.WriteLine("|♦  | ");
            Console.WriteLine("| Q | ");
            Console.WriteLine("|  ♦| ");
            Console.WriteLine("¯¯¯¯¯ ");
        }

        //Let the user decide to be honest with Gandolon and await his answer
        Console.WriteLine("Am I right? Enter Y for yes and N for no.");
        string answerOfUser = Console.ReadLine().Substring(0, 1).ToUpper();

        if (answerOfUser == "Y")
        {
            Console.WriteLine("I am the empowerd Gandolon - Visionaire of the brains!");
        }
        else if (answerOfUser == "N")
        {
            Console.WriteLine("WHAT? It can't be, you are lying! Gandolon never misses a mindshot!");
        }
        else
        {
            Console.WriteLine("You cant fool me around giving false anwers. This was the card you have drawn!");
        }
    }
}