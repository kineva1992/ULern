using System;

namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRublesWitchIf(int count)
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

        public static string PluralizeRubles(int count)
        {
            var result = "";

            if (count % 100 > 10 && count % 100 < 21)
                return "рублей";
            switch (count % 10)
            {
                case 1:
                    result = "рубль";
                    break;
                case 2:
                case 3:
                case 4:
                    result = "рубля";
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 0:
                    result = "рублей";
                    break;
                default:
                    throw new Exception("Нема такого слова");
            }

            return result;
        }

    }
}