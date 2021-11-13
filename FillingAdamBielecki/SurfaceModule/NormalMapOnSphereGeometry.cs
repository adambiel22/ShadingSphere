using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Filling
{
    public class NormalMapOnSphereGeometry : ISurfaceGeometryComputer
    {
        private readonly HalfSphereGeometry halfSphereGeometry;
        private readonly NormalMapGeometry normalMapGeometry;

        public NormalMapOnSphereGeometry(HalfSphereGeometry halfSphere, NormalMapGeometry normalMap)
        {
            halfSphereGeometry = halfSphere;
            normalMapGeometry = normalMap;
        }

        public Vector3D ComputeNormalVector(int x, int y)
        {
            if ( x == 433 && y == 476)
            {
                Debug.WriteLine((x, y));
            }
            Vector3D sphereVector = halfSphereGeometry.ComputeNormalVector(x, y);
            Vector3D normalMapVector = normalMapGeometry.ComputeNormalVector(x, y);
            Vector3D AxisVector = new Vector3D(-sphereVector.Y, sphereVector.X, 0);
            AxisVector = AxisVector / AxisVector.Norm;
            double sin = Math.Sqrt(sphereVector.X * sphereVector.X + sphereVector.Y * sphereVector.Y);
            double cos = sphereVector.Z;
            Matrix3D transformationMatrix = new Matrix3D(
                new double[,]
                {
                    {AxisVector.X * AxisVector.X * (1 - cos) + cos, AxisVector.X * AxisVector.Y * (1 - cos) - AxisVector.Z * sin, AxisVector.X * AxisVector.Z * (1 - cos) + AxisVector.Y * sin },
                    {AxisVector.X * AxisVector.Y * (1 - cos) + AxisVector.Z * sin,  AxisVector.Y * AxisVector.Y * (1 - cos) + cos, AxisVector.Y * AxisVector.Z * (1 - cos) - AxisVector.X * sin},
                    {AxisVector.X * AxisVector.Z * (1 - cos) - AxisVector.Y * sin, AxisVector.Y * AxisVector.Z * (1 - cos) + AxisVector.X * sin, AxisVector.Z * AxisVector.Z * (1 - cos) + cos }
                }) ;
            return transformationMatrix * normalMapVector;
        }

        public Vector3D ComputePixelPosition(int x, int y)
        {
            return halfSphereGeometry.ComputePixelPosition(x, y);
        }
    }
}
