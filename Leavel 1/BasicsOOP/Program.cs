using BasicsOOP.questions;
using System;
using System.Globalization;

namespace BasicsOOP
{
	public  class SuperBeautyImageFilter
	{
		public string ImageName;
		public double GaussianParameter;
		public void Run()
		{
			Console.WriteLine("Processing {0} with parameter {1}",
				ImageName,
				GaussianParameter.ToString(CultureInfo.InvariantCulture));
			//do something useful
		}
	}

	public static class ConvertStringToInt
	{
		public static int ToInt(this string arg)
		{
			return Convert.ToInt32(arg);
		}
	}

	class SomeClass
	{
		public static int s = 1;
		public int d = 1;

		public void Run()
		{
			Console.Write(s + " " + d + " ");
			s++; d++;
		}

		

		class Program
		{
			static void Main(string[] args)
			{
				//var city = new City();
				//city.Name = "Ekaterinburg";
				//city.Location = new GeoLocation();
				//city.Location.Latitude = 56.50;
				//city.Location.Longitude = 60.35;
				//Console.WriteLine("I love {0} located at ({1}, {2})",
				//	city.Name,
				//	city.Location.Longitude.ToString(CultureInfo.InvariantCulture),
				//	city.Location.Latitude.ToString(CultureInfo.InvariantCulture));

				var filter = new SuperBeautyImageFilter();
				filter.ImageName = "Paris.jpg";
				filter.GaussianParameter = 0.4;
				filter.Run();
			}
		}
	}
}
