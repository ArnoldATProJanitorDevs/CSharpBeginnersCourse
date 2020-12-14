using System;

namespace Example09___Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Oh look, it is Merlin in his early apprentice years.
            Mage Merlin = new Mage();

            //3.0 Prints out what spell he is going to cast and calls the function for a random spell.
            Console.WriteLine("The apprentice Merlin casts now: " + Merlin.castRandomSpell() + ".");
        }
    }

    //1. Class Mage, who is able to cast randomSpells, obviously he is a apprentice    
    class Mage
    {
        public string castRandomSpell()
        {
            string spellToCast = "";
            // getting a random number for the statement
            int randomNumber = new Random().Next(-1, 3);
            //3.1 taking a distinguishable variable and decide which case it is.
            switch (randomNumber)
            {
                case 0:
                    spellToCast = "Fireball";
                    break;
                case 1:
                    spellToCast = "Icebolt";
                    break;
                case 2:
                    spellToCast = "Electroshock";
                    break;
                //3.2 This is the default case, which will be called, if no other case meets the condition to be checked.
                default:
                    spellToCast = "Turn myself into a chicken! Winner winner chicken dinner";
                    break;

            }

            //3.3 returns the spell as a string to be printed out to the console
            return spellToCast;
        }
    }
}
