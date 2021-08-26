using System;
using System.Collections.Generic;
using System.Text;

namespace Branchings
{
    public static class Task
    {
        /*
        Вася решил научить своего младшего брата играть в шахматы. Но вот беда, брат еще слишком мал и никак не может запомнить как ходит ферзь. Как настоящий программист, Вася решил автоматизировать ручной труд по обучению начинающих шахматистов.

        Помогите ему написать программу, которая по шахматному ходу определяет корректный ли это ход ферзя. Координаты исходной и конечной позиции хода передаются строкой в обычной шахматной нотации, например, "a1".

        Как обычно, постарайтесь поразить Васю красотой и простотой получившегося кода!

        В любой непонятной ситуации пользуйтесь подсказками! Они бесплатны :)
         */
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
            Console.WriteLine("{0} - {1} {2}", from, to, IsCorrectMove(from, to));
        }


        /*
        Вы с Васей и Петей решили выбрать самые лучшие фотографии котиков в интернете. Для этого каждую фотографию каждый из вас оценил по стобалльной шкале. Естественно, тут же встал вопрос о том, как из трех оценок получить одну финальную.

        Вы опасаетесь, что каждый из вас сильно завысит оценку фотографиям своего котика. Поэтому было решено в качестве финальной оценки брать не среднее арифметическое, а медиану, то есть просто откинуть максимальную и минимальную оценки.

        Вася начал писать код выбора средней оценки из трех, но запутался в if-ах, и поэтому перепоручил эту задачу вам.

        Попробуйте не просто решить задачу, но и минимизировать количество проверок и максимально упростить условия проверок.
         */

        public static int MiddleOf(int a, int b, int c)
        {
            return a + b + c - Math.Min(Math.Min(a, b), c) - Math.Max(Math.Max(a, b), c);
        }

        public static int MiddleOfVer2(int a, int b, int c)
        {
            if (a <= b && a >= c || a >= b && a <= c) return a;
            if (b <= a && b >= c || b >= a && b <= c) return b;
            else return c;
        }

        /*
        В воскресенье Вася пошел в кружок робототехники и увидел там такой код управления боевым роботом:
        Код показался Васе слишком длинным, а к тому же еще и неряшливым. Вася поспорил с автором, что сможет написать функцию, делающую ровно то же самое, но всего в один оператор.

        Кажется, Вася погорячился... Или нет? Помогите ему не проиграть в споре!
         */
        static bool ShouldFireInLesson(bool enemyInFront, string enemyName, int robotHealth)
        {
            bool shouldFire = true;
            if (enemyInFront == true)
            {
                if (enemyName == "boss")
                {
                    if (robotHealth < 50) shouldFire = false;
                    if (robotHealth > 100) shouldFire = true;
                }
            }
            else
            {
                return false;
            }
            return shouldFire;
        }


        public static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
        {
            return enemyInFront && (enemyName != "boss" || robotHealth >= 50);        
        }

    }
}
