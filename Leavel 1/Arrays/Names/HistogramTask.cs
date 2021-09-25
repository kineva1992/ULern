using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            

            double[] daysCount = new double[31];
            string[] daysOfMounth = new string[31];

            for (int i = 1; i <= 31; i++)
            {
                daysOfMounth[i - 1] = i.ToString();
            }

            foreach (var item in names)
            {
                if (item.Name == name && item.BirthDate.Day != 1)
                {
                    daysCount[item.BirthDate.Day - 1] += 1;
                }
            }
            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name),
                daysOfMounth,
                daysCount);
        }
    }
}