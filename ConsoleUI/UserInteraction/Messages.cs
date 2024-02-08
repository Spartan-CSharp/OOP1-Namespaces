using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
