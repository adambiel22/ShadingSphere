using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filling
{
    public class HalfSphereGeometry : ISurfaceGeometryComputer
    {
        public int R { get; }
        public Point MidPoint { get; }

        public HalfSphereGeometry(int r, Point midPoint)
        {
            R = r;
            MidPoint = midPoint;
        }

        public Vector3D ComputeNormalVector(int x, int y)
        {
            if ((x - MidPoint.X) * (x - MidPoint.X) + (y - MidPoint.Y) * (y - MidPoint.Y) > R * R)
            {
                return new Vector3D(0, 0, 1);
            }
            Vector3D normalVector = ComputePixelPosition(x, y) -
                new Vector3D(MidPoint.X, MidPoint.Y, 0);
            return normalVector / normalVector.Norm;
        }

        public Vector3D ComputePixelPosition(int x, int y)
        {
            return new Vector3D(x, y,
                Math.Sqrt(-(x - MidPoint.X) * (x - MidPoint.X) -
                    (y - MidPoint.Y) * (y - MidPoint.Y) +
                    R * R));
        }
    }
}
