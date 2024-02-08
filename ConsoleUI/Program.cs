using System;

using ConsoleUI.Models;
using ConsoleUI.UserInteraction;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			PersonModel person = new PersonModel
			{
				FirstName = "Tim",
				LastName = "Corey"
			};

			Messages.GreetPerson(person);

			_ = Console.ReadLine();
		}
	}
}
