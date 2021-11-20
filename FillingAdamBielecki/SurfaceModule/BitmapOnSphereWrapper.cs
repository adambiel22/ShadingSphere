using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    static class BitmapOnSphereWrapper
    {
        public static int RectX(Vector3D sphereVector, int width, int height)
        {
            return (sphereVector.X == 0 && sphereVector.Z == 0)
                ? 0
                : (width - height) / 2 +
                (int)((height - 1) *
                (1 + Vector3D.Cos(new Vector3D(sphereVector.X, 0, sphereVector.Z), new Vector3D(1, 0, 0))) / 2);
        }
        public static int RectY(Vector3D sphereVector, int height)
        {
            return (int)((height - 1) *
                    (1 + Vector3D.Cos(sphereVector, new Vector3D(0, 1, 0))) / 2);
        }
    }
}
