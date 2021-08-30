using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeInterest
{
    public enum ChessFifure
    {
        King,
        Queen,
        Rook,
        Bishop,
        Knight,
        Pawn
    }
    public static class EndTask
    {
        //Cond1. Дана начальная и конечная клетки на шахматной доске.
        //Корректный ли это ход на пустой доске для: слона, коня, ладьи, ферзя, короля?

        public static void Chese(ChessFifure figure, string from, string to)
        {
            Console.WriteLine(figure.ToString() + " : {0}-{1} {2}", from, to, IsCorrectMove(figure,from,to));
        }

        private static bool IsCorrectMove(ChessFifure figure, string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //Смешивание фигур по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //Смешивние фигур по вертикали

            return figure switch
            {
                ChessFifure.King => (dx == 1 && dy == 1) || (dy == 0 && dx == 1) || (dx == 0 && dy == 1),
                ChessFifure.Queen => (dx == dy && dx != 0) || (dy == 0 && dx != 0)|| (dx == 0 && dy != 0),
                ChessFifure.Rook => (dy == 0 && dx != 0) || (dx == 0 && dy != 0),
                ChessFifure.Bishop => (dx == dy && dx != 0),
                ChessFifure.Knight => (dx != dy && ((dx == 2 && dy == 1) || (dy == 2 && dx == 1))),
                ChessFifure.Pawn => throw new NotImplementedException(),
                _ => throw new ArgumentException()
            };
        }

        //Cond2. Пролезет ли брус со сторонами x, y, z в отверстие со сторонами a, b, если его разрешается поворачивать на 90 градусов?

        public static void FitTheBlock(int x, int y, int z, int a, int b)
        {
            Console.WriteLine(ChecFit(x, y, z, a, b) ? "BLock fits" : "Block do not fit");

        }

        private static bool ChecFit(int x, int y , int z, int a, int b)
        {
            return CheckTwoSides(x, y, a, b) | CheckTwoSides(z, y, a, b) | CheckTwoSides(y, z, a, b);

                static bool CheckTwoSides(int side1, int side2, int a, int b)
            {
                return (side1 <= a && side2 <= b) || (side1 <= b && side2 <= a);
            }
        }

        /*
         Cond3. (1493. В одном шаге от счастья) 
        Дан номер трамвайного билета, в котором суммы первых трёх цифр и последних трёх цифр отличаются на 1 (но не сказано, в какую сторону). 
        Правда ли, что предыдущий или следующий билет счастливый?
         */

        public static void LuckyTicket(int number)
        {
            Console.WriteLine(CheckLucky(number + 1) || CheckLucky(number - 1)? "Yes" : "No");

            static bool CheckLucky(int number)
            {
                if (number < 0 || number > 99999)
                {
                    throw new ArgumentException();
                }
                int right = number % 1000;
                int left = number / 100;
                return GetSum(left) == GetSum(right);
            }
        }

        static int GetSum(int value)
        {
            var huderents = value / 100;
            var decimals = (value % 100) / 10;
            var ones = value % 10;
            return ones + decimals + huderents;
        }
    }
}

