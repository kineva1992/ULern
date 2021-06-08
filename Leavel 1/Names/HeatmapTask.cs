using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
           var days = new string[30];
            var mounts = new string[12];
            var heat = new double[30,12];
            for (int i = 2; i < 32; i++)
			{
                days[i - 2] = i.ToString();
			}

            for (int i = 1; i < 13; i++)
			{
                mounts[i - 1] = i.ToString();
			}

            foreach(var currentName in names) { 
            if(currentName.BirthDate.Day != 1) { 
                heat[currentName.BirthDate.Day - 2, currentName.BirthDate.Month - 1] += 1;
                }
            }
            return new HeatmapData("Пример карты интенсивностей", heat, days, mounts);
        }
    }
}