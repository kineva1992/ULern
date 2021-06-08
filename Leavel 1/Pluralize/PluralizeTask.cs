namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			string eding = "";
			var lastNumber = count % 10;
			if((count % 100) / 10 == 1) { 
			eding = "лей";
			}

			else if(lastNumber == 1) { 
			eding = "ль";
			}

			else if(lastNumber == 2 || lastNumber == 3 || lastNumber == 4) { 
			eding = "ля";
			}

			else eding = "лей";

			return "руб" + eding;

			
		}
	}
}