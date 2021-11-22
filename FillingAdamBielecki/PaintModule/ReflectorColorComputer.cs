using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public class ReflectorColorComputer : IColorComputer
    {
        public SurfaceSettings SurfaceSettings { get; set; }
        public int H { get; set; }
        public int M { get; set; }
        public Point ReflexPoint { get; set; }
        public Color LightColor { get; set; }

        public ReflectorColorComputer(SurfaceSettings surfaceSettings, int h, int m, Point reflexPoint, Color lightColor)
        {
            SurfaceSettings = surfaceSettings;
            H = h;
            M = m;
            ReflexPoint = reflexPoint;
            LightColor = lightColor;
        }

        public Color ComputeColor(int x, int y)
        {
            //obliczanie wektora od 
            Vector3D reflectorPosition = new Vector3D(SurfaceSettings.MidPoint.X, SurfaceSettings.MidPoint.Y, H);
            Vector3D reflexPointPosition = SurfaceSettings.SurfaceGeometryComputer.ComputePixelPosition(ReflexPoint.X, ReflexPoint.Y);
            Vector3D V_r = reflexPointPosition - reflectorPosition;
            V_r = V_r / V_r.Norm;
            Vector3D pointPosition = SurfaceSettings.SurfaceGeometryComputer.ComputePixelPosition(x, y);
            Vector3D L = pointPosition - reflectorPosition;
            L = L / L.Norm;
            Vector3D minusL = new Vector3D(-L.X, -L.Y, -L.Z);

            Vector3D normalVector = SurfaceSettings.SurfaceGeometryComputer.ComputeNormalVector(x, y);
            normalVector = normalVector / normalVector.Norm;

            Vector3D R = 2 * (normalVector * minusL) * normalVector - minusL;

            byte LightRed = (byte)(Math.Min(255 * Math.Pow(V_r * L, M), 255));

            byte Red = (byte)Math.Min(
                SurfaceSettings.K_d *
                LightRed * SurfaceSettings.GetPixelColor(x, y).R *
                Math.Max(normalVector * minusL, 0) / 255 +
                SurfaceSettings.K_s *
                LightRed * SurfaceSettings.GetPixelColor(x, y).R *
                Math.Pow(Math.Max(Vector3D.Cos(R, new Vector3D(0,0,1)), 0), SurfaceSettings.M) / 255,
                255);

            return Color.FromArgb(SurfaceSettings.GetPixelColor(x, y).A, Red, 0, 0);
        }
    }
}
