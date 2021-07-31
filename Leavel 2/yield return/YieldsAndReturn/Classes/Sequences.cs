using System;
using System.Collections.Generic;
using System.Text;

namespace YieldsAndReturn.Classes
{
    class Sequences
    {
		public static IEnumerable<int> Fibonacci
		{
			get
			{
				var a = 1;
				var b = 1;
				yield return 1;
				yield return 1;
				while (true)
				{
					var c = a + b;
					a = b;
					b = c;
					yield return c;
				}
			}
		}
		
		public static IEnumerable<int> Exponential(int multiplier)
		{
			var a = 1;

			while (true)
			{
				yield return a;
				a *= multiplier;
			}
		}
	}
}
