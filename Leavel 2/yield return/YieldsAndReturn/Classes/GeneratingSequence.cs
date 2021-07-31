using System;
using System.Collections.Generic;
using System.Text;

namespace YieldsAndReturn.Classes
{
    public class GeneratingSequence
    {
        public static IEnumerable<int> GenerateCycle(int maxValue)
        {
            var currnt = maxValue;
            while (true)
            {
                yield return currnt % maxValue;
                currnt++;

            }

            static IEnumerable<int> ZipSum(IEnumerable<int> first, IEnumerable<int> second)
            {
                var e1 = first.GetEnumerator();
                var e2 = second.GetEnumerator();
                while (e1.MoveNext())
                {
                    e2.MoveNext();
                    yield return e1.Current + e2.Current;
                }


            }



        }
    }
}
