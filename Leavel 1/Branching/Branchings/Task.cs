using System;
using System.Collections.Generic;
using System.Text;

namespace Branchings
{
   public static class Task
    {
        private static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали

            if (dx == 0 && dy == 0)
            {
                return false;
            }
            else if (dx == 0 || dy == 0)
            {
                return true;
            }
            else if (dx == dy)
            {
                return true;
            }
            else return false;
        }

        

        public static void TestMove(string from, string to)
        {
            Console.WriteLine("{0} - {1} {2}", from, to, IsCorrectMove(from,to));
        }

    }
}
