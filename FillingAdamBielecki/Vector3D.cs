using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public struct Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Norm => Math.Sqrt(X * X + Y * Y + Z * Z);

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3D operator +(Vector3D a, Vector3D b)
            => new Vector3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static double operator *(Vector3D a, Vector3D b)
            => a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        public static Vector3D operator -(Vector3D a, Vector3D b)
            => new Vector3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static Vector3D operator *(double a, Vector3D b)
            => new Vector3D(a * b.X, a * b.Y, a * b.Z);
        public static Vector3D operator /(Vector3D a, double b)
            => new Vector3D(a.X / b, a.Y / b, a.Z / b);
        public static Vector3D operator *(Matrix3D matrix, Vector3D vector)
            => new Vector3D(
                vector.X * matrix[0, 0] + vector.Y * matrix[0, 1] + vector.Z * matrix[0, 2],
                vector.X * matrix[1, 0] + vector.Y * matrix[1, 1] + vector.Z * matrix[1, 2],
                vector.X * matrix[2, 0] + vector.Y * matrix[2, 1] + vector.Z * matrix[2, 2]);
        public static implicit operator FPoint3D(Vector3D a)
            => new FPoint3D(a.X, a.Y, a.Z);

        public static double Cos(Vector3D a, Vector3D b)
        {
            return (a * b) / a.Norm / b.Norm;
        }

        public static Vector3D CrossProduct(Vector3D p0, Vector3D p1)
        {
            return new Vector3D(p0.Y * p1.Z - p0.Z * p1.Y, p0.Z * p1.X - p0.X * p1.Z, p0.X * p1.Y - p0.Y * p1.X);
        }

        public override string ToString()
        {
            return $"[{X}, {Y}, {Z}]";
        }
    }
}
