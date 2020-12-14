using System;

namespace Example04___Classes
{
	class Program
	{
		static void Main(string[] args)
		{
			//2. now the blueprints gets realized into an concrete object, with the call of the constructor
			Chest TreasureChest = new Chest();

			//3. After instantiating filling up the chest with 300 goldcoins -> That is a field, a field is an acessible member of an object. 
			// Properties are mostly similar, but they need extra effort and grant encapsulation, but for now, not so important.
			TreasureChest.goldcoins = 300;
			Console.WriteLine("Goldcoins of object " + TreasureChest.goldcoins);

			TreasureChest.goldcoins = 450;
			Console.WriteLine("Manipulated goldcoins of object " + TreasureChest.goldcoins);

			//5. we want to put our chests somewhere, still they aren't floating around in the void, therefore we got a treasureRoom right ahead
			Room TreasureRoom = new Room();

			//6. Linking our chest object to that treasureRoom since reference variables, it is linked not copied.
			TreasureRoom.chests = new Chest[3];
			TreasureRoom.chests[0] = TreasureChest;
			Console.WriteLine("TreasureRoom TreasureChest content " + TreasureRoom.chests[0].goldcoins);


			//7. linking means now that a change of the original object and its value will also effect the linkage
			TreasureChest.goldcoins = 300;
			Console.WriteLine("Manipulated the original object TreasureChest but the linkage will also be affected " +
			                  TreasureRoom.chests[0].goldcoins);
			//8. Does also work in the other direction
			TreasureRoom.chests[0].goldcoins = 99;
			Console.WriteLine("Manipulated the linked object TresaureChest stored to the TreasureRoom " +
			                  TreasureChest.goldcoins);
			//9. That is the difference between a reference-variable (object storage into variable) and a value-variable. A reference variable can be manipulated anywhere because all other locations have a reference where the origin object is safed.
			// a Value type on the other hand will be manipulated as a copy and not its original value.
			// It will come 100% clear in the next chapter, when functions will be coverd

			//10 SNEAK PEAK STATICS. There are classes, that aren't instantiable so called "static" just to mention them here because we are using "CONSOLE" a lot and this is a great example
			// Statics are handles in chapter 13 but for a sneak preview -> Remember the instantiation of the Chest? "Chest TreasureChest = new Chest();" After that, the instance is
			// "TreasureChest" and you acess fields and functions with "TreasureChest" and the "."-Operator. Statics can't be instantiated therefore you call the just the type and can 
			// then access with the "."-Operator. Like in "Console.WriteLine" -> Console is the type of that class "public static class Console"
		}
	}

	//1.What is a class? A Class is a blueprint for an object. What is an object? An object is the concretisation of that blueprint. Lets hit the example right away
	class Chest
	{
		public int goldcoins;
	}


	//4. another Class could be a Room
	class Room
	{
		public Chest[] chests;
	}
}