using System;
using System.Threading;

namespace Example10___For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Setting HP to 100
            int Hitpoints = 100;
            Console.WriteLine("1st attack incoming.");

            //2. looping for a fixed number of iterations
            for (int i = 15; i > 0; i--)
            {
                Hitpoints--;
                //2.1 this statement halts the execution of this program for the amount inside the braces. The unit is milliseconds
                Thread.Sleep(200);
                Console.WriteLine("HP: " + Hitpoints);
            }
            
            Console.WriteLine("1st attack did its damage.");


            
            Console.WriteLine("2nd attack incoming.");
            Thread.Sleep(1000);

            int cycles = new Random().Next(1, 150);

            //3. looping also for a fixed number of iterations, stored in a variable and different every program runcycle 
            for (int i = cycles; i > 0; i--)
            {
                Hitpoints--;
                Thread.Sleep(100);
                Console.WriteLine("HP: " + Hitpoints);
                if (Hitpoints < 1)
                {
                    Console.WriteLine("Player died!");
                    //3.1 this statement jumps out of the loop, even if there were cycles to finish
                    break;
                }
            }
            
            Console.WriteLine("2nd attack did its damage.");
            
            
            if(Hitpoints > 0)
            {
                Console.WriteLine("Player takes a healing potion");
                Thread.Sleep(2000);
                int healingPotionStrength = new Random().Next(1, 95);
                int hitpointBeforeHeal = Hitpoints;

                //3.2 looping also for a fixed number of iterations, stored in a variable and different every program runcycle 
                for (int i = 0; i < healingPotionStrength; i++)
                {
                    Hitpoints++;
                    Thread.Sleep(100);
                    Console.WriteLine("HP: " + Hitpoints);
                    if (Hitpoints >= 100)
                    {
                        healingPotionStrength = 100 - hitpointBeforeHeal;
                        Console.WriteLine("Player fully recovered!");
                        break;
                    }
                }

                Console.WriteLine("Healing Potion recovered " + healingPotionStrength + "HP.");
            }

            
            
        }
    }
}
