using System;
using System.Collections.Generic;


namespace Example02___Keywords
{
	class Program
	{
		static void Main(string[] args)
		{
			int variable = 0;
			int variable2 = 0;

			//1. Selection instructions
			//If Else If Else
			if (variable == 0)
			{
				//do some
			}
			
			if (variable2 < 0)
			{
				//do some
			}
			
			if (variable > 0)
			{
				//do some
			}

			if (variable == 1)
			{
				variable = 2;
			}
			else if (variable == 2)
			{
				variable = 1;
			}
			else
			{
				//do anything
			}

			//Switch-Case
			switch (variable)
			{
				case 1:
					variable = 2;
					break;
				case 2:
					//do some different
					break;
				default:
					//do some default
					break;
			}

			
			

			//2. Iteration instructions

			//do a thing for an specified amount of fixed iterations
			for (int runningIndex = 0; runningIndex < 1000; runningIndex++)
			{
				//do this exactly 1000 times (runningIndex 0-9)
			}

			List<object> chests = new List<object>();
			
			// do a thing for a specific amount, but depending on an object (like a List or an Array)
			foreach (var chest in chests)
			{
				//open chest and look inside
			}
			
			
			bool isGoldInChest = true;
			int goldInChest = 100;

			//loop until condition fails
			while (isGoldInChest == true)
			{
				//loot
				goldInChest--;
				if (goldInChest <= 0)
					isGoldInChest = false;
			}
			
			//alternative
			while (goldInChest > 0)
			{
				//loot
				goldInChest--;
			}

			do
			{
				//do this stuff at first
				goldInChest--;
				if (goldInChest <= 0)
					isGoldInChest = false;
			}
			// check condition to break afterwards
			while (isGoldInChest == true);
			
			//alternative
			do
			{
				goldInChest--;
			}
			while (goldInChest > 0);


			Console.WriteLine("Hello from main-function");
			
			// 4. Variable Keywords
			// variable type Keywords
			char letter = 'c';
			string weaponName = "sword";
			bool toLootOrNotToLoot = true;
			int gold = 24;
			uint healthpoints = 100;
			float goldWeight = 30.79f;
			double goldWeightExact = 30.7999999999998;
			int[] arrayOfInteger = new int[1] {123};
			string[] arrayOfStrings = new string[2] {"sword", "mace"};
			object undefinableObject = new object();


			//5. Class modifiers later
			//6. Modifier and Acess Modifier Keywords --> later on
		}


		//3. Jumping Instructions
		public static void MyFunction()
		{
			Console.WriteLine("Hello from my-function");


			bool fighting = true;
			bool opponentDead = false;  
			//seen in switch case , can be used in loops also
			while (fighting)
			{
				//hit opponent hard
				opponentDead = true;
				//when opponent dead, stop hitting by breaking of the loop
				if (opponentDead)
				{
					break;
				}
			}

			int amountOfLoot = 3;
			string[] rarity = new string[]{"common", "epic", "rare"};
			//used for overjumping an iteration
			for (int runningIndex = 0; runningIndex < amountOfLoot; runningIndex++)
			{
				//we only want to loot epic stuff!
				if (rarity[runningIndex] != "epic")
				{
					//jump over current iteration
					continue;
				}

				//lootEpic
			}

			int variable = 0;
			//this one can be used to jump to a specific case in switch case instructions
			switch (variable)
			{
				case 1:
					//do some
					goto case 2;
					break;
				case 2:
					//do some different
					goto case 1;
					break;
				default:
					//do some default stuff, when case 1 or 2 wasn't involved
					break;
			}

			// BUT! it is the the Ring from Lord of the Rings. Powerful, but dark. Don't use GOTO statements. 
			// Gotos are a relic out of forgotten times, when windows wasn't invented and a PC
			// was just a black screen with green letters and commands to be typed in.
		}
		//Return is used to go back to the point where we came from. It is the default for a function call (we will catch that later on)
		// For now watch the code and save it.

		void LookIntoMap()
		{
			//look into map

			return;
		}

		// a function can also return a variable with content inside. For example the Loot.
		Loot getLoot()
		{
			//loot the body

			return new Loot();
		}

		// There is another one called "yield". But this is not for beginner to get around.
		// If your curiosity is high then read the following explanation:
		// The yield keyword in combination with return allows to return multiple variables without defining a list or an array.

		// to make the list complete:
		// throw
		// try-catch
		// try-finally
		// try-catch-finally
		// checked, unchecked
		// fixed
		// lock

		// but these aren't good for us now. They will become handy, 
		//when we gained enough XP for a few level ups!
	}

	public class Loot
	{
	}
}