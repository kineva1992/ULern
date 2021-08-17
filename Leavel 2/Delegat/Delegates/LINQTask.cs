using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    class LINQTask
    {

        private static T FirstOrDefault<T>(IEnumerable<T> source, Func<T, bool> filter)
        {
            foreach (var element in source)
            {
                if (filter(element))
                {
                    return element;
                }
            }
            return default;
        }

        private static T FirstOrDefaultVer2<T>(IEnumerable<T> soccer, Func<T, bool> filter)
        {
            return soccer.FirstOrDefault(e => filter(e));
        }

        // TakeTask 

        private static IEnumerable<T> Take<T>(IEnumerable<T> source, int count)
        {
            var counter = 0;
            if (count == 0) yield break;
            foreach (var item in source)
            {
                yield return item;
                counter++;
                if (counter == count)
                    yield break;
            }
        }

        //решение через интерфейс IEnumerable

        private static IEnumerable<T> TakeVe2<T>(IEnumerable<T> soccer, int count)
        {
            var e = soccer.GetEnumerator();
            while (count-- > 0 && e.MoveNext())
            {
                yield return e.Current;            
            }
        }

        // Не надо создавать счетчик, отнимай от полученного 

        private static IEnumerable<T> Take2<T>(IEnumerable<T> source, int count)
        {
            if (count == 0)
                yield break;
            foreach (var e in source)
            {
                yield return e;
                if (--count == 0)
                    yield break;
            }
        }
    }

}
