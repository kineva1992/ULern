using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeInterest
{
    /*
        Эти задачи можно использовать для самостоятельного решения или для решения на семинарах. Пожалуйста, не публикуйте решения задач в комментариях.

        Expr10. Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.

        Expr11. Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.

        Expr12. 1885. Комфорт пассажиров

        Самолёт должен набрать высоту h метров в течение первых t секунд полёта и удерживать её в течение всего полёта. Разрешён набор высоты со скоростью не более чем v метров в секунду. До полного набора высоты запрещено снижаться. Известно, что уши заложены в те и только те моменты времени, когда самолёт поднимается со скоростью более x метров в секунду. Посчитайте минимальное и максимальное возможное время, в течение которого у пассажиров будут заложены уши. Считайте, что самолёт способен изменять скорость мгновенно.

        Expr13. 1084. Пусти козла в огород

        Козла пустили в квадратный огород и привязали к колышку. Колышек воткнули точно в центре огорода. Козёл ест всё, до чего дотянется, не перелезая через забор огорода и не разрывая веревку. Какая площадь огорода будет объедена? Даны длина веревки и размеры огорода.
     */
   public class TasksForTheWorkshop
    {

        //Expr10

        public static void CalculateSum()
        {
            int number = 1000;
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }


        //Expr11

        public static double CalculateAlnge(int hours, int minuts)
        {
            int hAngle = (hours * 60 + minuts) / 2;
            if (hAngle > 360)
                hAngle -= 360;
            int mAngle = minuts * 6;

            return Math.Abs(hAngle - mAngle);
        
        }

        public static double timeAngle(int h, int m)
        {
            double hAngle = 0.5D * (h * 60 + m);
            double mAngle = 6 * m;
            double angle = Math.Abs(hAngle - mAngle);
            angle = Math.Min(angle, 360 - angle);
            return angle;
        }
       
       //Expr12
       
       /*
        Исходные даныне:
        целые числа h, t, v, x (5000 ≤ h ≤ 12000; 50 ≤ t ≤ 1200; 1 ≤ x < v ≤ 100; h ≤ t · v), где
        h - высота полёта,
        t - время подъема до h,
        x - минимальная скорость подъема, начиная от которой закладывает уши
        v - максимальная скорость подъема самолета
        Пример: Ввод (10000, 500, 50, 10) -> Вывод (125 500)
       */
       
       public static void PassengersComfort(double h, double t, double x, double v)
       {
           
       if(h < 5000 ||
          h > 12000 ||
          t < 50 ||
          t > 1200 ||
          x < 1 ||
          x > v ||
          v > 100 ||
          t * v < h) throw new ArgumentExeption();
           
           double tMin;
           double tMax;
           
           tMax = t;
           TMin = (h - x * t) / (v - x);
           
           Console.WriteLine(tMin + " " +TMax);
       }
    }
    
    //Expr13
    public static double LengthToGetGoat(double l, double r)
    {
    const PI = Math.PI;
    double s = PI * (r*r);
     if(r < 2 * r)
     {
     double a = Math.Acos(l / 2 / r);
     s -= 4 * (a * r * r - l / 2 * r * Math.Sin(a));
     }
       return s;
    }
}
