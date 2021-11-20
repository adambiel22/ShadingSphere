using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Filling
{
    public class ProfessorNormalMapOnSphereGeometry : ISurfaceGeometryComputer
    { 
        public double K { get; set; }

        public ProfessorNormalMapOnSphereGeometry(HalfSphereGeometry halfSphere, NormalMapGeometry normalMap, double k)
        {
            if (k < 0 || k > 1)
            {
                throw new ArgumentException("Factor k should be in [0,1].");
            }
            halfSphereGeometry = halfSphere;
            normalMapGeometry = normalMap;
            K = k;
        }

        public Vector3D ComputeNormalVector(int x, int y)
        {
            Vector3D sphereVector = halfSphereGeometry.ComputeNormalVector(x, y);
            Vector3D normalMapVector = normalMapGeometry.ComputeNormalVector(
                BitmapOnSphereWrapper.RectX(sphereVector, normalMapGeometry.Width, normalMapGeometry.Height),
                BitmapOnSphereWrapper.RectY(sphereVector, normalMapGeometry.Height));
            Vector3D binormalVector =
                    sphereVector.X == 0 && sphereVector.Y == 0 && sphereVector.Z == 1
                    ? new Vector3D(0, 1, 0)
                    : Vector3D.CrossProduct(sphereVector, new Vector3D(0, 0, 1));
            Vector3D tangentialVector = Vector3D.CrossProduct(binormalVector, sphereVector);
            Matrix3D transformationMatrix = new Matrix3D(
                tangentialVector,
                binormalVector,
                sphereVector);
            return  K * sphereVector + (1 - K) * (transformationMatrix * normalMapVector);
        }

        public Vector3D ComputePixelPosition(int x, int y)
        {
            return halfSphereGeometry.ComputePixelPosition(x, y);
        }

        private readonly HalfSphereGeometry halfSphereGeometry;
        private readonly NormalMapGeometry normalMapGeometry;
    }
}
