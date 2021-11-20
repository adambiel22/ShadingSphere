using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filling
{
    public class SurfaceSettings
    {
        public double K_d { get; set; }
        public double K_s { get; set; }
        public Color SurfaceColor { get; set; }
        public bool IsPlain { get; set; }
        public int M { get; set; }
        public int R { get; set; }
        public Point MidPoint { get; set; }
        public ISurfaceGeometryComputer SurfaceGeometryComputer { get; set; }
        public void SetSurfaceBitmap(Bitmap surfaceBitmap)
        {
            bitmapManager.StartDrawing(surfaceBitmap);
        }

        public SurfaceSettings(double k_d, double k_s, Color surfaceColor,
            Bitmap surfaceBitmap, bool isPlain, int m, 
            ISurfaceGeometryComputer surfaceGeometryComputer, int r, Point midPoint)
        {
            K_d = k_d;
            K_s = k_s;
            SurfaceColor = surfaceColor;
            IsPlain = isPlain;
            M = m;
            SurfaceGeometryComputer = surfaceGeometryComputer;
            bitmapManager = new LockBitmap();
            bitmapManager.StartDrawing(surfaceBitmap);
            R = r;
            MidPoint = midPoint;
        }

        public Color GetPixelColor(int x, int y)
        {
            if (IsPlain)
            {
                return SurfaceColor;
            }
            else
            {
                HalfSphereGeometry halfSphereGeometry = new HalfSphereGeometry(R, MidPoint);
                Vector3D vector3D = halfSphereGeometry.ComputeNormalVector(x, y);
                return bitmapManager.GetPixel(
                    BitmapOnSphereWrapper.RectX(vector3D, bitmapManager.Width, bitmapManager.Height),
                    BitmapOnSphereWrapper.RectY(vector3D, bitmapManager.Height));
            }
        }

        BitmapManager bitmapManager;
    }
}
