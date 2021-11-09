﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Filling
{
    public struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x,  int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3D operator +(Point3D a, Point3D b)
        => new Point3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public static Point3D operator +(Point3D a, Point b)
        => new Point3D(a.X + b.X, a.Y + b.Y, a.Z);

        public static Point3D operator *(int a, Point3D b)
        => new Point3D(a * b.X, a * b.Y, a * b.Z);

        public static Point3D operator /(Point3D a, double b)
            => new Point3D((int)(a.X / b), (int)(a.Y / b), (int)(a.Z / b));

        public static implicit operator System.Drawing.Point(Point3D a)
            => new System.Drawing.Point(a.X, a.Y);

        public static double Dist(Point3D a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
        }

        public static int CrossProduct(Point3D p0, Point3D p1, Point3D p2)
        {
            return (p1.X - p0.X) * (p2.Y - p0.Y) - (p2.X - p0.X) * (p1.Y - p0.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
