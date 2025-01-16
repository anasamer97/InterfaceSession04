using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	internal class Airplane : IMovable, IFlyable
	{
		//Explicit Implination 
		//public void Backword()
		//{
		//    Console.WriteLine("Go Backword on Air");
		//}

		//public void Forword()
		//{
		//    Console.WriteLine("Go Forword on Air");
		//}

		//public void Left()
		//{
		//    Console.WriteLine("Go Left on Air");
		//}

		//public void Right()
		//{
		//    Console.WriteLine("Go Right on Air");
		//}
		void IMovable.Backword()
		{
			Console.WriteLine("Go Backword on Ground");
		}

		void IFlyable.Backword()
		{
			Console.WriteLine("Go Backword on Air");
		}

		void IMovable.Forword()
		{
			Console.WriteLine("Go Forword on Ground");
		}

		void IFlyable.Forword()
		{
			Console.WriteLine("Go Forword on Air");
		}

		void IMovable.Left()
		{
			Console.WriteLine("Go Left on Ground");
		}

		void IFlyable.Left()
		{
			Console.WriteLine("Go Left on Air");
		}

		void IMovable.Right()
		{
			Console.WriteLine("Go Right on Ground");

		}

		void IFlyable.Right()
		{
			Console.WriteLine("Go Right on Air");
		}
	}
}
