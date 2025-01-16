using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	public interface IShape
	{
		public double Area { get; }

		public void DisplayShapeInfo() { }
	}

	public interface ICircle : IShape
	{
		double Radius { get; }
	}

	public interface IRectangle : IShape
	{
		public double Length { get; }
		public double Width { get; }
	}
	
	public class Circle : ICircle
	{
		public double Radius { get; private set; }

		public Circle(double radius)
		{
			Radius = radius;
		}

		public double Area
		{
			get { return Math.PI * Math.Pow(Radius, 2); }
		}

		public void DisplayShapeInfo()
		{
			Console.WriteLine($"Shape: Circle");
			Console.WriteLine($"Radius: {Radius}");
			Console.WriteLine($"Area: {Area:F2}");
		}
	}


	public class Rectangle : IRectangle
	{
		public double Length { get; private set; }
		public double Width { get; private set; }

		public Rectangle(double length, double width)
		{
			Length = length;
			Width = width;
		}

		public double Area
		{
			get { return Length * Width; }  
		}

		public void DisplayShapeInfo()
		{
			Console.WriteLine($"Shape: Rectangle");
			Console.WriteLine($"Length: {Length}");
			Console.WriteLine($"Width: {Width}");
			Console.WriteLine($"Area: {Area:F2}");
		}
	}
}
