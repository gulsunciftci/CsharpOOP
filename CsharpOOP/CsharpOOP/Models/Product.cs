using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP.Models
{
	public class Product //public olduğunu belirtmezsek internal olur
	{

		//field
		int b; //field
			   //fieldlar hep private olarak kalır



		int _c;

        //propertyler hiçbir zaman içerisinde veri tutmazlar
		//ramdeki bir değeri getirirler
        public int c {
			get
			{
				return _c;
			} //getirmek
			set
			{
				_c = value;
			} //atamak
		} 



        public Product()
		{
			int a = 25; //local variable
			int b= a; //a'yı çağırmış olduk

			c = 12;
			Console.WriteLine(_c);
			Console.WriteLine(c);
		}
	}
}
