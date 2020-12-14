using System;
using System.Threading;

namespace Example12___Do_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int hitpoints = new Random().Next(50, 100);
            int damageToDeal = new Random().Next(50, 100);

            
            Console.WriteLine("Player got " + hitpoints + " HP left!");
            Console.WriteLine("Monster inflicts player with " + damageToDeal + " Damage!");
            Thread.Sleep(2000);
            
            //1. show a burndown of HP , always do damage
            do
            {
                hitpoints--;
                damageToDeal--;
                string loadingBar = ShowLoadingBar(hitpoints);
                Console.Clear();
                Console.Write("Doing Damage, HP left " + hitpoints + "%" + loadingBar);
                Thread.Sleep(70);
            }
            while (damageToDeal > 0 && hitpoints > 0);

            //2. Check if player has survived the attack
            if (hitpoints > 0)
                Console.WriteLine("Player survived");
            else
                Console.WriteLine("Player died!");

        }

        //3. Reusage of the same function (from last example) for two different things ;)
        public static string ShowLoadingBar(int status)
        {
            if (status > 99)
                return "[##########]";
            if (status > 89)
                return "[#########-]";
            if (status > 79)
                return "[########--]";
            if (status > 69)
                return "[#######---]";
            if (status > 59)
                return "[######----]";
            if (status > 49)
                return "[#####-----]";
            if (status > 39)
                return "[####------]";
            if (status > 29)
                return "[###-------]";
            if (status > 19)
                return "[##--------]";
            if (status > 9)
                return "[#---------]";
            else
                return "[----------]";
        }
    }
}
