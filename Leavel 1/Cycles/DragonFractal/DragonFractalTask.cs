// В этом пространстве имен содержатся средства для работы с изображениями. 
// Чтобы оно стало доступно, в проект был подключен Reference на сборку System.Drawing.dll
using System;
using System.Drawing;

namespace Fractals
{
	internal static class DragonFractalTask
	{
		private static double GetXCordinat(double x, double y, double angle)
		{
			return (x * Math.Cos(angle) - y * Math.Cos(angle) / Math.Sqrt(2));
		}

		private static double GetYCordinat(double x, double y, double angle)
		{
			return (x * Math.Cos(angle) + y * Math.Cos(angle) / Math.Sqrt(2));
		}

		internal static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
		{
			double x = 1.0;
			double y = 0.0;
			const double PI = Math.PI;

			Random randomNumberInt = new Random();

			for (int i = 0; i < iterationsCount; i++)
			{
				var oldX = x;
				if (randomNumberInt.Next(2) == 0)
				{
					x = GetXCordinat(x, y, Math.PI / 4);
					y = GetYCordinat(x, y, Math.PI / 4);
				}

				else
				{
					x = GetXCordinat(x, y, PI * 3 / 4) + 1;
					y = GetYCordinat(oldX, y, PI * 3 / 4);
				}

				pixels.SetPixel(x,y);
			}

		}
	}
}