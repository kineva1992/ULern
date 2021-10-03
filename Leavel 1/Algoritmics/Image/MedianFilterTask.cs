using System.Collections.Generic;
using System.Linq;

namespace Recognizer
{
	internal static class MedianFilterTask
	{
		/* 
		 * Для борьбы с пиксельным шумом, подобным тому, что на изображении,
		 * обычно применяют медианный фильтр, в котором цвет каждого пикселя, 
		 * заменяется на медиану всех цветов в некоторой окрестности пикселя.
		 * https://en.wikipedia.org/wiki/Median_filter
		 * 
		 * Используйте окно размером 3х3 для не граничных пикселей,
		 * Окно размером 2х2 для угловых и 3х2 или 2х3 для граничных.
		 */
		public static double[,] MedianFilter(double[,] original)
		{
			var lenX = original.GetLength(0);
			var lenY = original.GetLength(1);
			var currentMedian = new List<double>();
			var newImages = new double[lenX, lenY];

			for (int i = 0; i < lenX; i++)
			{
				for (int j = 0; j < lenY; j++)
				{
					for (int ii = -1; ii < 2; ii++)
						for (int jj = -1; jj < 2; jj++)
							if (i + ii >= 0 && j + jj >= 0 && i + ii < lenX && j + jj < lenY)
								currentMedian.Add(original[i + ii, j + jj]);

					currentMedian.Sort();
					var count = currentMedian.Count();

					if (count % 2 == 0)
						newImages[i, j] = (currentMedian[count / 2] + currentMedian[(count / 2 - 1)]) / 2;

					else
						newImages[i, j] = currentMedian[count / 2];

				}
			}

			return newImages;
		}
	}
}