using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP.Models
{
	public class Wizard : Character
	{

		public int DoMagic(int damage)
		{
			return damage * 5;
		}
	}
}
