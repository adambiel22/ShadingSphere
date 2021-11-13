using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public interface ISurfaceGeometryComputer
    {
        public Vector3D ComputeNormalVector(int x, int y);
        public Vector3D ComputePixelPosition(int x, int y);
    }
}
