using System;
namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;
        public double GetLength()
        {
            return Geometry.GetLength(this);
        }
        public Vector Add(Vector b)
        {
            return Geometry.Add(this, b);
        }
        public bool Belongs(Segment s)
        {
            return Geometry.IsVectorInSegment(this, s);
        }
    }

    public class Segment
    {
        public Vector Begin;
        public Vector End;
        public double GetLength()
        {
            return Geometry.GetLength(this);
        }
        public bool Contains(Vector v)
        {
            return Geometry.IsVectorInSegment(v, this);
        }
    }

    public class Geometry
    {
        public static double GetLength(Vector a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y);
        }

        public static double GetLength(Segment a)
        {
            Vector difference = Deduct(a.Begin, a.End);
            return Geometry.GetLength(difference);
        }

        public static Vector Add(Vector a, Vector b)
        {
            Vector c = new Vector();
            c.X = a.X + b.X;
            c.Y = a.Y + b.Y;
            return c;
        }

        public static Vector Deduct(Vector a, Vector b)
        {
            Vector c = new Vector();
            c.X = b.X - a.X;
            c.Y = b.Y - a.Y;
            return c;
        }

        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            double xDirection = segment.End.X - segment.Begin.X;
            double yDirection = segment.End.Y - segment.Begin.Y;
            double onLine = (-1) * yDirection * (segment.End.X - vector.X) + xDirection * (segment.End.Y - vector.Y);
            double minY = Math.Min(segment.Begin.Y, segment.End.Y);
            double minX = Math.Min(segment.Begin.X, segment.End.X);
            double maxY = Math.Max(segment.Begin.Y, segment.End.Y);
            double maxX = Math.Max(segment.Begin.X, segment.End.X);
            if (vector.X <= maxX && vector.Y <= maxY && vector.X >= minX && vector.Y >= minY)
                if (Math.Abs(onLine) < double.Epsilon)
                    return true;
            return false;
        }
    }
}