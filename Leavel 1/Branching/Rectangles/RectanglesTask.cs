using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			// так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
			if (Math.Abs(r1.Width) + Math.Abs(r2.Width) >= Math.Abs(r1.Left) + Math.Abs(r2.Right) &&
				r1.Height + r2.Height >= Math.Abs(r1.Top) + Math.Abs(r2.Bottom))
				return true;
			else
				return false;
		}

		private static int GetSegmentsIntersectionLength(int r1Left, int r1Right, int r2Left, int r2Right)
		{
			int left = Math.Min(r1Left, r2Left);
			int right = Math.Min(r1Right, r2Right);
			return Math.Max(right - left, 0);
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
			int xIntersection = GetSegmentsIntersectionLength(r1.Left, r1.Right, r2.Left, r2.Right);
			int yIntersection = GetSegmentsIntersectionLength(r1.Top, r1.Bottom, r2.Top, r2.Bottom);

			return xIntersection * yIntersection;
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			return -1;
		}
	}
}