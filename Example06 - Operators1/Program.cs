using System;
using System.Threading;

namespace Example06___Operators1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. One operator already used, was the assigment operator. It stores a value into a variable
            int goldOfCharacter = 24;

            //2. Now if a player gets more gold "+"-operator
            int pileOfGold = 30;
            //2.1 player picks up the pile of gold.
            goldOfCharacter = goldOfCharacter + pileOfGold;

            //3. Character spends some gold in a shop for a new sword
            int priceOfSword = 25;
            //3.1 Player buys sword
            goldOfCharacter = goldOfCharacter - priceOfSword;

            //4. Charmander spits fire onto a plant pokemon (it is very effective)
            int damageOfEmber = 30;
            // 4.1 because it is effective, there is a multiplicator
            int effectiveMulti = 2;
            int bulbasaurHP = 100;
            
            // 4.2 the muliplication operator *
            int damage = damageOfEmber * effectiveMulti;
            bulbasaurHP -= damageOfEmber;

            //5. Division
            // An Attack, that will instantly half the Hitpoints
            float floatHitPoints = 55;
            float halfHitpoints = floatHitPoints / 2;
            

            //6. Division Integer  
            // An Attack, that will instantly half the Hitpoints since it is not common to have floats as hitpoints but integers. 
            // We want 0-100. It will keep the integer result in front of the comma (e.g. 55/2 = 27 R1 --> will only safe 27)
            int integerHitPoints = 55;
            int integerHalfHitpoints = integerHitPoints / 2;
            
            integerHitPoints = 54;
            integerHalfHitpoints = integerHitPoints / 2;

           

            //7. Reminder / Modulo
            // What is left after the integer division will be written into the variable. (e.g. 55/2 = 27 rest = 1 (27*2 = 54 ==> 54+1 = 55))
            // Drinking a fortune potion (will only be effective when your hitpoints are divideable by 2)
            integerHitPoints = 55;
            int fortunePotionIsEffective = integerHitPoints % 2;
            
            integerHitPoints = 54;
            fortunePotionIsEffective = integerHitPoints % 2;

            //7.2 Reminder / Modulo
            // What is left after the integer division will be written into the variable. (e.g. 55/2 = 27 rest = 1 (27*2 = 54 ==> 54+1 = 55))
            // Critical hit, if the damage you have made is divideable by 3
            int damageDone = 124;
            int criticalHit = damageDone % 3;
            
          
            //8. unary Increment
            // A HOT (heal over time), that incraeses the Hitpoints like a druid hotting his mates in World of Warcraft
            // Cast Rejuvenation Tier 1
            for (int i = 0; i < 5; i++)
            {
                integerHitPoints++;
                Console.WriteLine("Rejuvenation did 1 heal.");
                Thread.Sleep(1000);    
            }
            
            // Cast Rejuvenation Tier 2
            for (int i = 0; i < 5; i++)
            {
                integerHitPoints+= 40;
                Console.WriteLine("Rejuvenation did 40 heal.");
                Thread.Sleep(1000);    
            }
            
            //9. unary decrement
            // A DOT (damage over time), that decreses the Hitpoints like a warlock dotting his opponents in World of Warcraft
            // Cast Curse of Agony Tier 1
            for (int i = 0; i < 5; i++)
            {
                integerHitPoints--;
                Console.WriteLine("Curse of Agony did 1 damage.");
                Thread.Sleep(1000);
            }

           
            Random random = new Random();
            // Cast Curse of Agony Tier 2
            for (int i = 0; i < 5; i++)
            {
                int agonyDamage =  random.Next(0,250);
                integerHitPoints-= agonyDamage;
                Console.WriteLine("Curse of Agony did {0} damage.", agonyDamage);
                Thread.Sleep(1000);
            }
            
            

        }
    }
}
