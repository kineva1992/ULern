namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
            var ending = "";
            var lastNumber = count % 10;
            if (count % 100 / 10 == 1)
                return ending + "лей";
            else if (lastNumber == 1)
                return ending + "ль";
            else if (lastNumber == 2 || lastNumber == 3 || lastNumber == 4)
                return ending + "ля";
            else
                ending = "лей";

            return "руб" + ending;
        }
	}
}