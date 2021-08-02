using System;
using System.Collections.Generic;
using System.Linq;

namespace yield
{

	public static class MovingMaxTask
	{
		public static IEnumerable<DataPoint> MovingMax(this IEnumerable<DataPoint> data, int windowWidth)
		{
            if (windowWidth <= 0)
            {
				throw new ArgumentOutOfRangeException();
            }
			int i = 0;
			LinkedList<double> maxPotencials = new LinkedList<double>();
			Queue<double> windowNumbers = new Queue<double>();
            foreach (DataPoint dataPoint in data)
            {
				if (i <= windowWidth)
					i++;
				else if (maxPotencials.Count == 0)
					windowNumbers.Dequeue();
				else if (maxPotencials.First.Value == windowNumbers.Dequeue())
					maxPotencials.RemoveFirst();
				windowNumbers.Equals(dataPoint.OriginalY);
				while (maxPotencials.Count > 0 && maxPotencials.Last.Value <= dataPoint.OriginalY)
					maxPotencials.RemoveLast();
				maxPotencials.AddLast(dataPoint.OriginalY);
				var newDataPoint = dataPoint.WithMaxY(maxPotencials.First.Value);
				yield return newDataPoint;
            }
		}


	}
}