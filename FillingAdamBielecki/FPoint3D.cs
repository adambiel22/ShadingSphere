using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Filling
{
    public struct FPoint3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public FPoint3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static FPoint3D operator +(FPoint3D a, FPoint3D b)
        => new FPoint3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public static FPoint3D operator +(FPoint3D a, Point b)
        => new FPoint3D(a.X + b.X, a.Y + b.Y, a.Z);

        public static FPoint3D operator *(int a, FPoint3D b)
        => new FPoint3D(a * b.X, a * b.Y, a * b.Z);

        public static FPoint3D operator /(FPoint3D a, double b)
            => new FPoint3D((int)(a.X / b), (int)(a.Y / b), (int)(a.Z / b));

        public static implicit operator System.Drawing.Point(FPoint3D a)
            => new System.Drawing.Point((int)a.X, (int)a.Y);

        public static implicit operator Vector3D(FPoint3D a)
            => new Vector3D(a.X, a.Y, a.Z);

        public static double Dist(FPoint3D a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
        }

        public static double CrossProduct(FPoint3D p0, FPoint3D p1, FPoint3D p2)
        {
            return (p1.X - p0.X) * (p2.Y - p0.Y) - (p2.X - p0.X) * (p1.Y - p0.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
