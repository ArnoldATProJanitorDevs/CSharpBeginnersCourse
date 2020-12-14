using System;

namespace Example05___Functions
{
	class Program
	{
		static void Main(string[] args)
		{
			//1. instantiating our chest and name it LOOTBOX
			Chest Lootbox = new Chest();

			//2. saving the return of the function to a variable
			int goldFromLootbox = Lootbox.openChest();

			//3. Printing out to the console, how much gold the Lootbox contained 
			Console.WriteLine("Opening now our Lootbox: " + goldFromLootbox);
			Console.WriteLine("Opening now our Lootbox: " + Lootbox.openChest());


			//4. Advantage is the creation of the amount only when the function gets called. We could provide dozens of lootboxes and just when it is opened, the real contet
			// would be revealed. For that we could also implement a function --> Reusage of once written functions
			Chest[] Lootboxes = new Chest[50];

			//5. Creating 50 Lootboxes (someone purchased the gold package)
			for (int i = 0; i < 50; i++)
			{
				Lootboxes[i] = new Chest();
			}

			//6. Open all of them at once!
			int goldOfAllLootboxes = openAndAccumulateLootboxContent(Lootboxes);
			Console.WriteLine("All the gold from Lootboxes:" + goldOfAllLootboxes);
			Console.WriteLine("All the gold from Lootboxes:" + openAndAccumulateLootboxContent(Lootboxes));


			// 7. difference between VALUE and REFERENCE types
			// 7.1 VALUE TYPE , beeing manipluated else where, doesnt effect the original one
			goldOfAllLootboxes = 77;

			Console.WriteLine("Before call " + goldOfAllLootboxes);
			ChangeValueType(goldOfAllLootboxes);
			Console.WriteLine("After call " + goldOfAllLootboxes);

			// 7.2 REFERENCE TYPE , the value type stored inside a reference variable gets manipluated somewhere else and DOES effect the original one
			Lootboxes[0].goldCoins = 123;

			Console.WriteLine("Before call " + Lootboxes[0].goldCoins);
			ChangeReferenceType(Lootboxes);
			Console.WriteLine("After call " + Lootboxes[0].goldCoins);
		}

		//7. Takes an array of chests, creates an bufferVariable for the gold, Loops over all inpassed Chests
		// returns the gold
		public static int openAndAccumulateLootboxContent(Chest[] chests)
		{
			int accumulatedGoldAmount = 0;

			foreach (Chest chest in chests)
			{
				accumulatedGoldAmount += chest.openChest();
			}

			return accumulatedGoldAmount;
		}

		// 7.1
		public static void ChangeValueType(int gold)
		{
			gold = 144;

			Console.WriteLine("ChangeValueType " + gold);
		}

		// 7.2
		public static void ChangeReferenceType(Chest[] Lootboxes)
		{
			Lootboxes[0].goldCoins = 456;

			Console.WriteLine("ChangeReferenceType " + Lootboxes[0].goldCoins);
		}
	}

	// 8.6 the same goes for classes, but now is not meant the access, but who can instantiate it. The acess is modfied by the reference variable it is stored to.
	// public class PublicClass {}
	// private class PrivateClass {}
	// protected class ProtectedClass {}
	// internal class InternalClass {}


	class Chest
	{
		public int goldCoins;

		public int openChest()
		{
			Random InstanceOfClassRandom = new Random();
			this.goldCoins = InstanceOfClassRandom.Next(0, 100);
			return this.goldCoins;
		}
	}
}