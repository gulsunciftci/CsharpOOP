using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP.Models
{
	public class Dog : BaseClass, IAnimal
	{
		public void Voice()
		{
			Console.WriteLine("Hav hav");
		}
	}
}
