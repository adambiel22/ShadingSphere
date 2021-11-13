using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

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
            Color pixelColor = NormalMap.GetPixel(x % NormalMap.Width,
                y  % NormalMap.Height);
            Vector3D normalVector = new Vector3D(
                (pixelColor.R - 127.5) / 127.5,
                (pixelColor.G - 127.5) / 127.5,
                pixelColor.B / 255.0
                );
            return normalVector / normalVector.Norm;
        }

        public Vector3D ComputePixelPosition(int x, int y)
        {
            return new Vector3D(x, y, 0);
        }
    }
}
