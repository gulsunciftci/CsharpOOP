using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP.Models
{
	public sealed class Archer:Character
	{
        public Archer()
        {
            Damage = 3;
        }

		public override void Attack()
		{
			Console.WriteLine("Ok ile saldır");
		}
	}
}
