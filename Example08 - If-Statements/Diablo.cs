using System;

namespace Example08___If_Statements
{
	public static class Diablo
	{
		public static void RunDiablo()
		{
			//2. Instantiating new player
			DiabloCharacter Witchdoctor = new DiabloCharacter("Witchdoctor");

			//2.1 generating a random car damage
			int zombieDamage = new Random().Next(1, 250);
			Console.WriteLine("Zombie hits " + Witchdoctor.Name + " and causes " + zombieDamage + " damage.");

			//2.2 Substracting zombie damage from its hitpoints
			Witchdoctor.Hitpoints -= zombieDamage;
			Console.WriteLine(Witchdoctor.Name + " has now " + Witchdoctor.Hitpoints + " HP.");

			//2.3 Tries to use a healing potion
			Witchdoctor.UsingHealingPotion();
		}


		//1. Have a player class, with 2 fields: HP and Name.
		class DiabloCharacter
		{
			public int Hitpoints;
			public string Name;

			//1.1 Constructor writing initial values when creating / instantiating
			public DiabloCharacter(string name)
			{
				this.Hitpoints = 100;
				this.Name = name;
			}

			//1.2 This function writes out console line, if player is dead or not. 
			public void UsingHealingPotion()
			{
				//TIP: what if i flip the first and the second statement checks? 
				if (this.Hitpoints > 100)
					Console.WriteLine(this.Name + " has full HP. No need for a potion.");
				else if (this.Hitpoints > 0)
				{
					if (this.Hitpoints + 75 > 100)
						this.Hitpoints = 100;
					else
						this.Hitpoints += 75;

					Console.WriteLine(this.Name + " has taken a healing potion. Refreshing! (HP: " + this.Hitpoints +
					                  ")");
				}
				else
					Console.WriteLine(this.Name + " tried to take a healing potion. Too late!");
			}
		}
	}
}