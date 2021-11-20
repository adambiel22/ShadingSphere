using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filling.SurfaceModule
{
    public class WrappedNormalGeometry : ISurfaceGeometryComputer
    {
        public Point MidPoint { get; set; }
        public int R { get; set; }

        public WrappedNormalGeometry(NormalMapGeometry normalMapGeometry, Point midPoint, int r)
        {
            this.normalMapGeometry = normalMapGeometry;
            MidPoint = midPoint;
            R = r;
        }

        public Vector3D ComputeNormalVector(int x, int y)
        {
            throw new NotImplementedException();
        }

        public Vector3D ComputePixelPosition(int x, int y)
        {
            throw new NotImplementedException();
        }

        private readonly NormalMapGeometry normalMapGeometry;
    }
}
