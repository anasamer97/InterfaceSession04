 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	internal interface IMyType
	{
		// What can you write inside an Interafce?
		// Signature for property

		public int Salary { get; set; } // Automatic property


	    // Signature for methods
		public void myFun();
		

		// Default Implemented Method => C# 8 .NETCore 3.1 [2019]

		public void Print()
		{
			Console.WriteLine("Hello from default implemented method");
		}
	}


	class myType : IMyType
	{
		public int Salary { get; set; }//Automatic Attributes BK F 

		public void myFun()
		{
			Console.WriteLine("Hello my function");
		}

	}




}
