using System;
using System.Threading;

namespace Example11____While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. setting a loading status to zero
            int loadingStatus = 0;

            // 2. Condition for the while loop is the status of loading must be below 100
            while (loadingStatus < 100)
            {
                //2.1 increases the loadingStatus each cycle of the while loop
                loadingStatus++;
                //2.2 writes a visualisation for a loading bar into string variable
                string loadingBar = ShowLoadingBar(loadingStatus);
                //2.3 clears the console each cycle for the effect of a real loading bar
                Console.Clear();
                Console.Write(loadingStatus + "%");
                Console.Write(loadingBar);
                //2.4 simulates real loading character by delaying more and less each cycle
                Thread.Sleep(new Random().Next(10,500));
            }

        }

        // 3. Returns the string to visualize a loading bar
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
