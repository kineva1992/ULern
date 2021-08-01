using System.Collections.Generic;

namespace yield
{
    public static class MovingAverageTask
    {
        public static IEnumerable<DataPoint> MovingAverage(this IEnumerable<DataPoint> data, int windowWidth)
        {
            if (data == null) yield break;
            var queue = new Queue<double>();
            var sum = 0.0;
            var beginningWindowWidth = windowWidth;
            foreach (var e in data)
            {
                if (beginningWindowWidth != 0) beginningWindowWidth--;
                var newDataPoint = GetCopyDataPoint(e);
                queue.Enqueue(e.OriginalY);
                sum += e.OriginalY;
                if (queue.Count > windowWidth)
                    sum -= queue.Dequeue();

                newDataPoint.AvgSmoothedY = sum / (windowWidth - beginningWindowWidth);
                yield return newDataPoint;
            }
        }

        public static DataPoint GetCopyDataPoint(DataPoint dataPoint)
        {
            return new DataPoint
            {
                X = dataPoint.X,
                OriginalY = dataPoint.OriginalY,
                ExpSmoothedY = dataPoint.ExpSmoothedY,
                AvgSmoothedY = dataPoint.AvgSmoothedY,
                MaxY = dataPoint.MaxY
            };
        }
    }
}