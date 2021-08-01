using System.Collections.Generic;

namespace yield
{
    public static class ExpSmoothingTask
    {
        public static IEnumerable<DataPoint> SmoothExponentialy(this IEnumerable<DataPoint> data, double alpha)
        {
            bool firstTime = true;
            var currentItem = data.GetEnumerator();
            double prevY = 0;

            while (currentItem.MoveNext())
            {
                double tempY = currentItem.Current.OriginalY;
                if (firstTime)
                {
                    tempY = GetSmoothedY(tempY, prevY, alpha + 1 - alpha);
                    firstTime = false;
                }
                else
                {
                    tempY = GetSmoothedY(tempY, prevY, alpha);
                }

                currentItem.Current.ExpSmoothedY = prevY = tempY;
                yield return currentItem.Current;
            }
        }

        static double GetSmoothedY(double y, double preY, double alpha)
        {
            return alpha * y + (1 - alpha) * preY;
        }
    }
}