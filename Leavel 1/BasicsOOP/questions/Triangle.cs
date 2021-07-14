using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOOP.questions
{
	public class Program
    {
		public static void Main()
		{
			var triangle = new Triangle
			{
				A = new Point { X = 0, Y = 0 },
				B = new Point { X = 1, Y = 2 },
				C = new Point { X = 3, Y = 2 }
			};
			Console.WriteLine(triangle.ToString());
		}
	}
	internal class Triangle
	{
		public Point A;
		public Point B;
		public Point C;

		public override string ToString()
		{
			return $"({A}) ({B}) ({C})";
		}
	}
	internal class Point
	{
		public double X;
		public double Y;

		public override string ToString()
		{
			return $"{X} {Y}";
		}
	}
}
