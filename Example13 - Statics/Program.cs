using System;
using System.Collections.Generic;

namespace Example13____Statics
{
    class Program
    {

        static void Main(string[] args)
        {
            //1. instantiating 2 player
            Player Player1 = new Player("Eric");
            Player Player2 = new Player("Newton");

            //2. shows instructions on screen
            Logger.PrintLogMessage("Enter put to put an item into the storage box");
            Logger.PrintLogMessage("Enter take to take an item from the storage box");
            Logger.PrintLogMessage("Enter exit to quit the program and see the final result");

            //3. reads user input
            var userInput = Console.ReadLine();
            

            //4. handles user input
            while(userInput.ToUpper() != "EXIT")
            {

                //4.1 if put was entered -> put item into box
                if(userInput.ToUpper().Equals("PUT")){
                    //  Attention, here you can't take the instance of the created player. YOu have to take the type because of the static;
                    Player.StorageBox.PutItemIntoStorageBox(Player1);
                }
                //4.2 if take was entered -> take item from box
                else if(userInput.ToUpper().Equals("TAKE")){
                    //  Attention, here you can't take the instance of the created player. YOu have to take the type because of the static;
                    Player.StorageBox.TakeItemFromStorageBox(Player1);
                }

                userInput = Console.ReadLine();
            }

            //5. shows final message on screen
            Logger.PrintLogMessage("Newton is also looking into the storageBox and it contains "
                                   + Player.StorageBox.ItemList.Count + " items now");
        }
    }

    // static logger class, cant be instantiated
    static class Logger
    {
        public static void PrintLogMessage(string message)
        {
            Console.WriteLine(DateTime.Now + " " + message + ".");
        }
    }


    // player class, can be instantiated
    class Player
    {   
        public string name;
        //all instances of player share the identical StorageBox with the content of that class field/properties
        public static StorageBox StorageBox = new StorageBox();
        public Player(string name)
        {
            Logger.PrintLogMessage("A new Player with the name of " + name + " joined the game");
            this.name = name;
        }
    }

    // StorageBox class
    class StorageBox
    {
        // a list is something like an array. It also got a strict type definiton, but a list offers more pleasant handling with large datatsets.
        // We cover this toopic in detail in the next course. C# Advanced course
        public List<string> ItemList = new List<string>();
        int index = 0;
        

        // prints the number of items inside
        public void CheckItemsCount()
        {
            Logger.PrintLogMessage("Items inside the storageBox " + this.ItemList.Count.ToString());
        }

        // adds an item to the list
        public void PutItemIntoStorageBox(Player player)
        {
            this.ItemList.Add("Item" + index++);
            Logger.PrintLogMessage(player.name + " put an item into the box");
            this.CheckItemsCount();
        }

        // removes an item from the list, if no item is inside, extra message will be printed out
        public void TakeItemFromStorageBox(Player player)
        {
            // instead of array.Length comes for a list the list.Count method to get the length of it
            if (this.ItemList.Count > 0)
            {
                //the method "RemoveAt" allows us to remove a specific item inside the list. An array does not allow this.
                this.ItemList.RemoveAt(this.ItemList.Count - 1);
                Logger.PrintLogMessage(player.name + " has taken out an item from the box");
                this.CheckItemsCount();
            }
            else
            {
                Logger.PrintLogMessage("The storageBox does not contain any items.");
            }
        }
    }
}
