using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DataIntegrity.Data
{
    class Ratio
    {
        public Ratio(int num, int den)
        {
            Numerator = num;
            Denominator = den;
            Value = (double)num / den;
            if (den <= 0) throw new ArgumentException();
        }

        public readonly int Numerator; //числитель
        public readonly int Denominator; //знаменатель
        public readonly double Value; //значение дроби Numerator / Denominator

        public static void Check(int num, int den)
        {
            var ratio = new Ratio(num, den);
            Console.WriteLine("{0}/{1} = {2}",
                ratio.Numerator, ratio.Denominator,
                ratio.Value.ToString(CultureInfo.InvariantCulture));
        }
    }
}
