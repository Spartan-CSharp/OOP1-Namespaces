using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Models
{
	internal class PersonModel
	{
		internal string FirstName
		{
			get; set;
		}
		internal string LastName
		{
			get; set;
		}
		internal string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}
	}
}
