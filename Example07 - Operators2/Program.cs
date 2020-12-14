using System;

namespace Example07___Operators2
{
	class Program
	{
		static void Main(string[] args)
		{
			//3. Creating the enemyWarlord King Arthur
			Warlord KingArthur = new Warlord();
			//3.1 Setting his Battalion size to 100 - without soldiers inside 
			//(You see here the .-Operator => This is the access modifier and grants you access to all public fields/properties of a class, also to its methods / functions)
			KingArthur.Battalions = new Battalion[100];

			//3.2 for the size of the battalions (Watch out Length -1 because of Index - access) filling up the battaltions with soldiers 
			for (int i = 0; i < KingArthur.Battalions.Length - 1; i++)
			{
				//3.3 accessing each battalion of the battalionArray and assign it a new Battalion with soldiers inside
				KingArthur.Battalions[i] = CreateNewBattalion();
			}


			//4 Printing out the length of the battalions since it is public (also for the player visible)
			Console.WriteLine("How many battalions does King Arthur have? The answer is: " +
			                  KingArthur.Battalions.Length);
			// 5. Printing out the number of soldiers inside the first battalion (depending who is asking - realized via string argument)
			Console.WriteLine("King Arthur himself asks for soldier information about his first battalion " +
			                  KingArthur.Battalions[0].GetInfoAboutSoldiers("KingArthur"));
			Console.WriteLine("Player asks for soldier information about King Arhurs first battalion " +
			                  KingArthur.Battalions[0].GetInfoAboutSoldiers("Player"));
		}

		//3.4 Creating an instance of the Battalion-Class 
		static Battalion CreateNewBattalion()
		{
			//3.4.1 instantiation the Random Class to get a random number from it
			Random randomGenerator = new Random();
			//3.4.2 get the random number between 250 and 1000
			int numberOfSoldiersInBattalion = randomGenerator.Next(250, 1000);
			//3.4.3 create a battalion and pass the constructor the number of soldiers
			Battalion newBattalion = new Battalion(numberOfSoldiersInBattalion);

			//3.4.4 returning the battalion to the caller of this function
			return newBattalion;
		}
	}


	//1. Class Warlord with a field of Battalions
	class Warlord
	{
		//1.1 Array of Battalions
		public Battalion[] Battalions;
	}


	//2. Class Battalion with a private field with the number of Soldiers inside a battalion
	class Battalion
	{
		private int numberOfSoldiers;

		//2.1 constructor, sets the number of soldiers, when this class gets instantiated to an object
		public Battalion(int soldiersInBattalion)
		{
			this.numberOfSoldiers = soldiersInBattalion;
		}

		//2.2 will check who is asking for informations and then response with the real amount or zero. 
		//Zero when the accessor of the function is not allowed to get information about the size of the battalion.
		public int GetInfoAboutSoldiers(string WhoIsAsking)
		{
			// if WhoIsAsking == KingArthur -> return numberOfSoldiers
			// everybody else can be blocked by setting numberOfSoldiers to private. The language does not allow to acess this private field
			if (WhoIsAsking == "KingArthur")
				return this.numberOfSoldiers;

			else return 0;
		}

		//6. Acess Modifiers (function Keywords are) public, private
		//6.1 every other assembly / class / function is able to call this function
		public void PublicStaticVoidFunction()
		{
		}

		//6.2 only same class is able to call this function
		private void PrivateStaticVoidFunction()
		{
		}

		//6.3 only same class or inhertited classes are able to call this function
		protected void ProtectedStaticVoidFunction()
		{
		}

		//6.4 only same assembly is able to call this function
		internal void InternalStaticVoidFunction()
		{
		}

		// 6.5 There are more and a few can be combined, but that would go too far for now.
	}
}