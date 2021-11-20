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
        public NormalMapGeometry(Bitmap normalMap, IBitmapManagerCreator bitmapManagerCreator)
        {
            bitmapManager = bitmapManagerCreator.CreateBitmapManager();
            bitmapManager.StartDrawing(normalMap);
        }

        public void SetNormalMap(Bitmap normalMap)
        {
            bitmapManager.StartDrawing(normalMap);
        }
        public int Height => bitmapManager.Height;
        public int Width => bitmapManager.Width;

        public Vector3D ComputeNormalVector(int x, int y)
        {
            Color pixelColor = bitmapManager.GetPixel(x % Width, y % Height);
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

        private BitmapManager bitmapManager;
    }
}
