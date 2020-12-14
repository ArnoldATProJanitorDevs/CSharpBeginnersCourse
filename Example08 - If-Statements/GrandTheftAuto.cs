using System;

namespace Example08___If_Statements
{
	public static class GrandTheftAuto
	{
		public static void RunGTA()
		{
			//2. Instantiating new player
			GTACharacter Trevor = new GTACharacter("Trevor");

			//2.1 generating a random car damage
			int carDamage = new Random().Next(1, 250);
			Console.WriteLine("Car hits " + Trevor.Name + " and causes " + carDamage + " damage.");

			//2.2 Substracting car damage from its hitpoints
			Trevor.Hitpoints -= carDamage;
			Console.WriteLine(Trevor.Name + " has now " + Trevor.Hitpoints + " HP.");

			//2.3 check if damage was lethal or not
			Trevor.CheckIfDead();
		}


		//1. Have a player class, with 3 fields: HP, Name and a bool if Dead or not.
		class GTACharacter
		{
			public int Hitpoints;
			public string Name;

			//1.1 Constructor writing initial values when creating / instantiating
			public GTACharacter(string name)
			{
				this.Hitpoints = 100;
				this.Name = name;
			}

			//1.2 This function writes out console line, if player is dead or not. 
			public void CheckIfDead()
			{
				if (this.Hitpoints <= 0)
				{
					Console.WriteLine(this.Name + " died in a car accident.");
					Console.WriteLine("WASTED");
				}
				else if (this.Hitpoints > 0)
				{
					Console.WriteLine(this.Name + " ist still alive.");
				}
			}
		}
	}
}