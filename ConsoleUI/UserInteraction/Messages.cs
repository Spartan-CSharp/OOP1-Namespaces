using System;

using ConsoleUI.Models;

namespace ConsoleUI.UserInteraction
{
	internal static class Messages
	{
		internal static void GreetPerson(PersonModel person)
		{
			Console.WriteLine($"Hello {person.FullName}!");
		}
	}
}
