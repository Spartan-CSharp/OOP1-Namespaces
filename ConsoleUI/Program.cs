using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleUI.Models;
using ConsoleUI.UserInteraction;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
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
}
