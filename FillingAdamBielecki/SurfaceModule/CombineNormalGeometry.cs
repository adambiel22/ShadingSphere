using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{

    public class CombineNormalGeometry : ISurfaceGeometryComputer
    {
        private readonly ISurfaceGeometryComputer surfaceGeometryComputer1;
        private readonly ISurfaceGeometryComputer surfaceGeometryComputer2;
        public int D { get; set; }

        public CombineNormalGeometry(ISurfaceGeometryComputer surfaceGeometry1, ISurfaceGeometryComputer surfaceGeometry2)
        {
            surfaceGeometryComputer1 = surfaceGeometry1;
            surfaceGeometryComputer2 = surfaceGeometry2;
        }

        public Vector3D ComputeNormalVector(int x, int y)
        {
            Vector3D sphereVector = surfaceGeometryComputer1.ComputeNormalVector(x, y);
            Vector3D normalMapVector = surfaceGeometryComputer2.ComputeNormalVector(x, y);
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
                });
            return transformationMatrix * normalMapVector;
        }

        public Vector3D ComputePixelPosition(int x, int y)
        {
            return surfaceGeometryComputer1.ComputePixelPosition(x, y) + surfaceGeometryComputer2.ComputePixelPosition(x, y);
        }
    }
}
