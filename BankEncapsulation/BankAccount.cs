using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}
		private double balance = 0;
		//experimenting beginning
		public void UserOption()
		{
			int userInput = 0;
			do
			{
				Console.WriteLine("What would you like to do? Enter 1 for Deposit. Enter 2 for Get Balance. Enter 3 for Withdraw. Enter 4 for Exit");
				userInput = int.Parse(Console.ReadLine());

				if (userInput == 1)
				{
					Deposit();
				}
				else if (userInput == 2)
				{
					GetBalance();
					Console.WriteLine(GetBalance());
				}

				else if (userInput == 3)
				{

				}
				////else
				//{
				//	Console.WriteLine("Error. Please enter 1 for Depsoit or enter 2 for Get Balance.");

				//}

			}
			while (userInput == 1 || userInput == 2 || userInput == 3);

        }
		//experimenting end
		public void Deposit()
		{
			Console.WriteLine("How much money would you like to deposit?");
			double userInput = double.Parse(Console.ReadLine());
			balance += userInput;
		}

		public void Withdraw()
		{
			int[] withdrawAmount = new int[] { 10, 20, 50, 100 };
			Console.WriteLine("How much money would you like to withdraw?");
			int userInput = int.Parse(Console.ReadLine());
			switch (userInput)
			{
				case 10:
					balance -= userInput;
					break;
			}
		}

		public double GetBalance()
		{
			return balance;
		}
	}
}

