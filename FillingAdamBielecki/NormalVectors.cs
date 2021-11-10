using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace Filling
{
    public static class NormalVectors
    {
        public static Vector3D SphereHalfNormalVector(double x, double y, double R, Point midPoint)
        {
            if ((x - midPoint.X) * (x - midPoint.X) + (y - midPoint.Y) * (y - midPoint.Y) > R * R)
            {
                return new Vector3D(0, 0, 1);
            }
            Vector3D normalVector = new Vector3D(x, y, SphereZ(x, y, R, midPoint)) -
                new Vector3D(midPoint.X, midPoint.Y, 0);
            return normalVector / normalVector.Norm;
        }
        public static double SphereZ(double x, double y, double R, Point midPoint)
        {
            return Math.Sqrt(
                -(x - midPoint.X) * (x - midPoint.X) -
                (y - midPoint.Y) * (y - midPoint.Y) + 
                R * R);
        }
        public static Color ReflexColor(
            Color lightColor, 
            Color pixelColor, 
            Vector3D normalVector,
            Vector3D pixelLocation,
            Vector3D lightLocation,
            double kd, double ks, int m)
        {
            if (pixelLocation.X == 605 && pixelLocation.Y == 307)
            {
                Debug.WriteLine((pixelLocation.X, pixelLocation.Y));
            }
            normalVector = normalVector / normalVector.Norm;
            Vector3D L = lightLocation - pixelLocation;
            L = L / L.Norm;
            Vector3D R = 2 * (normalVector * L) * normalVector - L;
            Vector3D V = new Vector3D(0, 0, 1);
            byte Red = (byte)Math.Min(kd * lightColor.R * pixelColor.R * Math.Max(normalVector * L, 0) / 255 +
                ks * lightColor.R * pixelColor.R * Math.Pow(Math.Max(Vector3D.cos(R, V), 0), m) / 255, 255);

          

            byte Green = (byte)(kd * lightColor.G * pixelColor.G * Math.Max(normalVector * L, 0) / 255 +
                ks * lightColor.G * pixelColor.G * Math.Pow(Math.Max(Vector3D.cos(R, V), 0), m) / 255);

            byte Blue = (byte)(kd * lightColor.B * pixelColor.B * Math.Max(normalVector * L, 0) / 255 +
                ks * lightColor.B * pixelColor.B * Math.Pow(Math.Max(Vector3D.cos(R, V), 0), m) / 255);

            return Color.FromArgb(pixelColor.A, Red, Green, Blue);
        }
    }
}
