using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace RefactorMe
{
    class Draw
    {
        static float x, y;
        static Graphics graphics;

        public static void Initialize ( Graphics newGraphics )
        {
            graphics = newGraphics;
            graphics.SmoothingMode = SmoothingMode.None;
            graphics.Clear(Color.Black);
        }

        public static void SetPosition(float x0, float y0)
        {x = x0; y = y0;}

        public static void MakeIt(Pen pen, double length, double angle)
        {
        //Делает шаг длиной dlina в направлении ugol и рисует пройденную траекторию
            var x1 = (float)(x + length * Math.Cos(angle));
            var y1 = (float)(y + length * Math.Sin(angle));
            graphics.DrawLine(pen, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void Change(double length, double angle)
        {
            x = (float)(x + length * Math.Cos(angle)); 
            y = (float)(y + length * Math.Sin(angle));
        }
    }

    public class ImpossibleSquare
    {
        public static void SideOne(int shirina, int visota) {
            var sz = Math.Min(shirina, visota);
            //Рисуем 1-ую сторону
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.375f, 0);
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), Math.PI / 4);
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI);
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, Math.PI / 2);
            RefactorMe.Draw.Change(sz * 0.04f, -Math.PI);
            RefactorMe.Draw.Change(sz * 0.04f * Math.Sqrt(2), 3 * Math.PI / 4);
        }

        public static void SideTwo(int shirina, int visota)
        {
            var sz = Math.Min(shirina, visota);
            //Рисуем 2-ую сторону
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.375f, -Math.PI / 2);
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.375f, -Math.PI / 2 + Math.PI);
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, -Math.PI / 2 + Math.PI / 2);
            RefactorMe.Draw.Change(sz * 0.04f, -Math.PI / 2 - Math.PI);
            RefactorMe.Draw.Change(sz * 0.04f * Math.Sqrt(2), -Math.PI / 2 + 3 * Math.PI / 4);
        }

        public static void SideThree(int shirina, int visota)
        {
            var sz = Math.Min(shirina, visota);
            //Рисуем 3-ю сторону
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI);
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), Math.PI + Math.PI / 4);
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI + Math.PI);
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, Math.PI + Math.PI / 2);
            RefactorMe.Draw.Change(sz * 0.04f, Math.PI - Math.PI);
            RefactorMe.Draw.Change(sz * 0.04f * Math.Sqrt(2), Math.PI + 3 * Math.PI / 4);
        }

        public static void SideFour(int shirina, int visota)
        {
            var sz = Math.Min(shirina, visota);
            //Рисуем 4-ую сторону
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI / 2);
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI / 2 + Math.PI);
            RefactorMe.Draw.MakeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, Math.PI / 2 + Math.PI / 2);
            RefactorMe.Draw.Change(sz * 0.04f, Math.PI / 2 - Math.PI);
            RefactorMe.Draw.Change(sz * 0.04f * Math.Sqrt(2), Math.PI / 2 + 3 * Math.PI / 4);
        }

        public static void Draw(int shirina, int visota, double angleTurn, Graphics graphica)
        {
            // ugolPovorota пока не используется, но будет использоваться в будущем
            RefactorMe.Draw.Initialize(graphica);

            var sz = Math.Min(shirina, visota);

            var diagonal_length = Math.Sqrt(2) * (sz * 0.375f + sz * 0.04f) / 2;
            var x0 = (float)(diagonal_length * Math.Cos(Math.PI / 4 + Math.PI)) + shirina / 2f;
            var y0 = (float)(diagonal_length * Math.Sin(Math.PI / 4 + Math.PI)) + visota / 2f;

            RefactorMe.Draw.SetPosition(x0, y0);
            //Превая сторона
            SideOne(shirina, visota);
            //Вторая сторона
            SideTwo(shirina, visota);
            //Третья сторона
            SideThree(shirina, visota);
            //Третья сторона
            SideFour(shirina, visota);
        }
    }
}