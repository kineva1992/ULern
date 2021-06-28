using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOOP.questions
{
	public class GeoLocation
	{
		public double Latitude;
		public double Longitude;
	}

	public class City
	{
		public string Name;
		public GeoLocation Location = new GeoLocation();
	}

	}
