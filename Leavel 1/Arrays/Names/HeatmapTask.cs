using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var days = new string[30];
            var mounts = new string[12];
            var heat = new double[30, 12];

            //Приведение дней в строку.
            for (int i = 2; i < days.Length + 2; i++)
            {
                days[i - 2] = i.ToString();
            }

            //Приведение месяцев в строку.
            for (int i = 1; i < mounts.Length + 1; i++)
            {
                mounts[i - 1] = i.ToString();
            }
            //
            foreach (var item in names)
            {
                if (item.BirthDate.Day != 1)
                {
                    heat[item.BirthDate.Day - 2, item.BirthDate.Month - 1] += 1;
                }
            }
            return new HeatmapData("Пример карты интенсивностей", 
                heat, 
                days, 
                mounts);
        }
    }
}