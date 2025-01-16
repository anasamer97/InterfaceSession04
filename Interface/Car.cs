using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	internal class Car : IMovable
	{
		//Implicit Implemtation 
		public void Backword()
		{
			Console.WriteLine("Go Backword on Ground");
		}

		public void Forword()
		{
			Console.WriteLine("Go Forword on Ground");
		}

		public void Left()
		{
			Console.WriteLine("Go Left on Ground");
		}

		public void Right()
		{
			Console.WriteLine("Go Right on Ground");
		}
	}
}
