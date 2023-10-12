using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP.Models
{
	public class Writer
	{
        public  string Name { get; set; }
		public string SurName { get; set; }

		public void Write(string BookName)
		{
			Console.WriteLine($"{ BookName} kitabı {Name} {SurName} adlı yazarın kitabıdır.");
		}
	}
}
