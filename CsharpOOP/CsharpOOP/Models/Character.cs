using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP.Models
{
	public class Character
	{
		public string CharacterName { get; set; }
		public int Damage { get; set; }
		public int Armor { get; set; }

		public virtual void Attack()
		{
			Console.WriteLine("Normal saldırı yap");
		}
	}
}
