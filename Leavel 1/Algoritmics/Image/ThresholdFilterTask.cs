using System.Collections.Generic;

namespace Recognizer
{
	public static class ThresholdFilterTask
	{
		public static double[,] ThresholdFilter(double[,] original, double whitePixelsFraction)
		{
			var lenX = original.GetLength(0);
			var lenY = original.GetLength(1);
			var allPixels = new List<double>();
			var t = 0.0;
			double whitePixelCount;

			for (int x = 0; x <= 1; x++)
			{
				for (int i = 0; i < lenX; i++)
				{
					for (int j = 0; j < lenY; j++)
					{
						if (x == 0)
							allPixels.Add(original[i, j]);
						else
						{
							if (original[i, j] >= t)
								original[i, j] = 1.0;
							else
								original[i, j] = 0.0;
						}
					}

				}
				allPixels.Sort();
				var count = allPixels.Count;
				var orignalLength = original.Length;
				whitePixelCount = (orignalLength * whitePixelsFraction);
				if (whitePixelCount == 0.0)
					t = int.MaxValue;
				else
				{
					var tIndex = (int)(count - whitePixelCount);
					t = allPixels[tIndex];
				}
			}
			return original;

		}
	}
}