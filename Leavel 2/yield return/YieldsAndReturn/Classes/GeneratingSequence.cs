using System;
using System.Collections.Generic;
using System.Text;

namespace YieldsAndReturn.Classes
{
   public static class GeneratingSequence
    {
        public static IEnumerable<int> GenerateCycle(int maxValue)
        {
            var currnt = maxValue;
            while (true)
            {
                yield return currnt % maxValue;
                currnt++;
            
            }

//            private static IEnumerable<int> ZipSum(IEnumerable<int> first, IEnumerable<int> second)
//            {
//                var e1 = first.GetEnumerator();
//                var e2 = second.GetEnumerator();
//                while (...)
//        ...
//}



    }
    }
}
