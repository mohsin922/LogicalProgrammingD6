using System;
namespace LogicalProgramming
{

	public class VendingMachine
	{
		// total is for calculating total notes
		static int i = 0;
		static int total = 0;

		static int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
		static int money;

		public static int calculate(int money, int[] notes)
		{
			
			int rem;
			if (money == 0)
			{
				return -1;
			}
			else
			{
				if (money >= notes[i])
				{
					
					int calculateNotes = money / notes[i];
					rem = money % notes[i];
					money = rem;
					total += calculateNotes;
					Console.WriteLine(notes[i] + " Notes -------> " + calculateNotes);
				}
				i++;
				return calculate(money, notes);
			}
		}

		public static void Main(String[] args)
		{
			

			//ask the user enter the money
			Console.WriteLine("Enter the Amount:");
			money = Convert.ToInt32(Console.ReadLine());

			// Creating The Object of Vending MAchine class
			VendingMachine.calculate(money, notes);
			Console.WriteLine("Total Number of Notes are :" + total);
		}
	}


}