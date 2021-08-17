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
    }

    // TakeTask 
}
