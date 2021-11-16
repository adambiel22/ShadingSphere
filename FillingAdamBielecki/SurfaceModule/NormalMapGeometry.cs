using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Filling
{
    public class NormalMapGeometry : ISurfaceGeometryComputer
    {
        public Bitmap NormalMap { get; set; }


        public NormalMapGeometry(Bitmap normalMap)
        {
            NormalMap = normalMap;
        }
        
        public Vector3D ComputeNormalVector(int x, int y)
        {
            //var _lock = NormalMap.LockBits(new Rectangle(x % NormalMap.Width,
            //    y % NormalMap.Height, 1, 1),
            //    System.Drawing.Imaging.ImageLockMode.ReadOnly,
            //    NormalMap.PixelFormat);
            ////byte[]  pixel = new byte[4];
            ////Marshal.Copy(_lock.Scan0, pixel, 0, 4);
            //Color pixelColor = Color.FromArgb(_lock.Scan0.ToInt32());

            //NormalMap.UnlockBits(_lock);
            Color pixelColor = NormalMap.GetPixel(x % NormalMap.Width, y % NormalMap.Height);

            Vector3D normalVector = new Vector3D(
                (pixelColor.R - 127.5) / 127.5,
                (pixelColor.G - 127.5) / 127.5,
                pixelColor.B / 255.0);
            return normalVector / normalVector.Norm;
        }

        public Vector3D ComputePixelPosition(int x, int y)
        {
            return new Vector3D(x, y, 0);
        }
    }
}
