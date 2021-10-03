namespace Recognizer
{
	public static class GrayscaleTask
	{
		/* 
		 * Переведите изображение в серую гамму.
		 * 
		 * original[x, y] - массив пикселей с координатами x, y. 
		 * Каждый канал R,G,B лежит в диапазоне от 0 до 255.
		 * 
		 * Получившийся массив должен иметь те же размеры, 
		 * grayscale[x, y] - яркость пикселя (x,y) в диапазоне от 0.0 до 1.0
		 *
		 * Используйте формулу:
		 * Яркость = (0.299*R + 0.587*G + 0.114*B) / 255
		 * 
		 * Почему формула именно такая — читайте в википедии 
		 * http://ru.wikipedia.org/wiki/Оттенки_серого
		 */

		public static double[,] ToGrayscale(Pixel[,] original)
		{
			var lenX = original.GetLength(0);
			var lenY = original.GetLength(1);
			var grayScale = new double[lenX, lenY];

			for (int i = 0; i < lenX; i++)
			{
				for (int j = 0; j < lenY; j++)
				{
					var red = original[i, j].R;
					var green = original[i, j].G;
					var blue = original[i, j].B;
					grayScale[i, j] = ((0.299 * red) + (0.587 * green) + (0.114 * blue)) / 255;
				}
			}
			return grayScale;
		}
	}
}