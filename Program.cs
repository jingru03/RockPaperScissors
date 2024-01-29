using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Rock-Paper-Scissors");
			Console.Write("Enter your name: ");
			string pName = Console.ReadLine();

			int pHealth = 3;
			int cHealth = 3;

			while (pHealth > 0 && cHealth > 0)
			{
				Console.Write("Choose your action (q = rock, w = paper, e = scissors): ");
				string pChoice = Console.ReadLine();


				Random r = new Random();
				string[] choices = { "q", "w", "e" };
				string cChoice = choices[r.Next(choices.Length)];

				string winner = "";
				if ((pChoice == "r" && cChoice == "e") || (pChoice == "w" && cChoice == "r") || (pChoice == "e" && cChoice == "w"))
				{
					winner = "player";
				} else if (pChoice == cChoice)
				{
					winner = "tie";
				} else
				{
					winner = "computer";
				}

				Console.WriteLine($"{pName} action: {pChoice}  Computer action: {cChoice}");

				if (winner == "player")
				{
					Console.WriteLine($"{pName} won this turn!");
					cHealth--;
				}
				else if (winner == "computer")
				{
					Console.WriteLine($"{pName} lose this turn!");
					pHealth--;
				}
				else
				{
					Console.WriteLine("It is a tie!");
				}
				Console.WriteLine($"{pName}'s health: {pHealth}  Computer's health: {cHealth}\n");
			}
			if (pHealth == 0)
			{
				Console.WriteLine($"Sorry, {pName} lose!");
			} else
			{
				Console.WriteLine($"Congratulations, {pName} won!");
			}
		}
		
	}
}
