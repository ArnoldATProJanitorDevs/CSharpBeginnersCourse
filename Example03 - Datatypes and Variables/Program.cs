using System;
using System.Linq;

namespace Example03___Variables_and_Datatypes
{
    class Program
    {

        //1.1. they are all based on a struct a value type combination
        public struct CompositeValues {
            int gold;
            uint healthpoints;
        }


        static void Main(string[] args)
        {
            // 1. Common variables to store values
            char letter = 'c';
            bool toLootOrNotToLoot = true;
            int gold = 24;
            uint healthpoints = 100;
            float goldWeight = 30.79F;
            double goldWeightExact = 30.7999999999998;
           

            //2. Common variables to store also values, but not the value itself, but a reference to that value
            string weaponName = "sword";
            string[] arrayOfStrings = new string[2];
            arrayOfStrings[0] = "sword";
            arrayOfStrings[1] = "mace";
            string[] arrayOfStrings2 = new string[2]{"sword", "mace"};
            int[] arrayOfInteger = new int[1]{123};
            object undefinableObject = new object();


            //2.1 an array comes with predefined out of the box methods.
            // we reinitialize the array of strings and call it armory, since it is matching
            int[] battalionsStrengths = new int[]{77,88,99,33,22,11,44,66,44,55,101,99,587,25,214,9,15,14,56};
            // our armory got 2 weapons, a swort and a mace. How do we access now a weapon? With [index].
            // since we are programmers , we start counting at 0. The size of our armory is 2 , 1 sword and 1 mace, to get the sword;
            Console.WriteLine("Strength of our first Battalion, Sire: " + battalionsStrengths[0]);
            // to get the mace
            Console.WriteLine("Strength of our second Battalion, Sire: " + battalionsStrengths[1]);
            //2.2 We can see that our armory has the size of two, but there will be times, when we can't see like here. THerefore an array comes with a lot of 
            // handy methods right of the box like:
            Console.WriteLine("The strength of our whole army, Sire: " + battalionsStrengths.Sum() + ".");
            Console.WriteLine("The strongest battalion, Sire: " + battalionsStrengths.Max() + ".");
            Console.WriteLine("The weakest battalion, Sire: " + battalionsStrengths.Min() + ".");
            //2.3 there are a lot of more functions, but we want to keep it simple, because knowing all array-methods is not the main goal of the course. Knowing the length and how to access is mostly enough.

            //3. so what is a Reference? Imagine your play as a character inside an RPG (ROLE PLAYING GAME) and your hitpoints get hurt by falling damage. Then the concrete value of this HP are decreased.
            // Your Hitpoints-value is a value type.
            //4. Imagine you want to open one of three large chests. In order to open one, you must decide which one you want to open. THe decision creates a link between your brain and the chest, this is the reference. In other words, creating a link between existing objects
            // is a reference.
            //5. We will see the difference in a few moments, because we need something else to make it really clear. For now remember that there are 2 types of variables:
            // 1) Value types (int char, double, float, bool)
            // 2) Reference Types: Objects (string, arrays, objects)

            // Asking what an Object is? Next Chapter!


            

        }
    }
}
