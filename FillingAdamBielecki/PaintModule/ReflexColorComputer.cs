using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public class ReflexColorComputer : IColorComputer
    {
        public SurfaceSettings SurfaceSettings { get; set; }
        public LightSource LightSource { get; set; }

        public ReflexColorComputer(SurfaceSettings surfaceSettings, LightSource lightSource)
        {
            SurfaceSettings = surfaceSettings;
            LightSource = lightSource;
        }

        public Color ComputeColor(int x, int y)
        {
            Vector3D normalVector = SurfaceSettings.SurfaceGeometryComputer.ComputeNormalVector(x, y);
            normalVector = normalVector / normalVector.Norm;
            Vector3D L = LightSource.Position - SurfaceSettings.SurfaceGeometryComputer.ComputePixelPosition(x, y);
            L = L / L.Norm;
            Vector3D R = 2 * (normalVector * L) * normalVector - L;
            Vector3D V = new Vector3D(0, 0, 1);
            byte Red = (byte)Math.Min(
                SurfaceSettings.K_d * 
                LightSource.Color.R * SurfaceSettings.GetPixelColor(x, y).R * 
                Math.Max(normalVector * L, 0) / 255 +
                SurfaceSettings.K_s * 
                LightSource.Color.R * SurfaceSettings.GetPixelColor(x, y).R * 
                Math.Pow(Math.Max(Vector3D.Cos(R, V), 0), SurfaceSettings.M) / 255, 
                255);

            byte Green = (byte)Math.Min(
                SurfaceSettings.K_d *
                LightSource.Color.G * SurfaceSettings.GetPixelColor(x, y).G *
                Math.Max(normalVector * L, 0) / 255 +
                SurfaceSettings.K_s *
                LightSource.Color.G * SurfaceSettings.GetPixelColor(x, y).G *
                Math.Pow(Math.Max(Vector3D.Cos(R, V), 0), SurfaceSettings.M) / 255,
                255);

            byte Blue = (byte)Math.Min(
                SurfaceSettings.K_d *
                LightSource.Color.B * SurfaceSettings.GetPixelColor(x, y).B *
                Math.Max(normalVector * L, 0) / 255 +
                SurfaceSettings.K_s *
                LightSource.Color.B * SurfaceSettings.GetPixelColor(x, y).B *
                Math.Pow(Math.Max(Vector3D.Cos(R, V), 0), SurfaceSettings.M) / 255,
                255);

            return Color.FromArgb(SurfaceSettings.GetPixelColor(x, y).A, Red, Green, Blue);
        }
    }
}
