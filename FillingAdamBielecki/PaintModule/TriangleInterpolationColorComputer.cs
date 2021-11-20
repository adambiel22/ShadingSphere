using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Filling
{
    public class TriangleInterpolationColorComputer : IColorComputer
    {
        public IColorComputer baseColorComputer;
        public Point[] Triangle { get; set; }

        public TriangleInterpolationColorComputer(IColorComputer baseColorComputer)
        {
            this.baseColorComputer = baseColorComputer;
        }

        public Color ComputeColor(int x, int y)
        {
            Vector3D pixelVector = new Vector3D(x, y, 0);
            Vector3D v0Vector = new Vector3D(Triangle[0].X, Triangle[0].Y, 0) - pixelVector;
            Vector3D v1Vector = new Vector3D(Triangle[1].X, Triangle[1].Y, 0) - pixelVector;
            Vector3D v2Vector = new Vector3D(Triangle[2].X, Triangle[2].Y, 0) - pixelVector;

            double v0 = Vector3D.CrossProduct(v2Vector, v1Vector).Z / 2;
            double v1 = Vector3D.CrossProduct(v0Vector, v2Vector).Z / 2;
            double v2 = Vector3D.CrossProduct(v1Vector, v0Vector).Z / 2;
            double sum = v0 + v1 + v2;

            if (sum == 0)
            {
                Debug.WriteLine("stop");
            }

            double v0influence = v0 / sum;
            double v1influence = v1 / sum;
            double v2influence = v2 / sum;

            Color v0color = baseColorComputer.ComputeColor(Triangle[0].X, Triangle[0].Y);
            Color v1color = baseColorComputer.ComputeColor(Triangle[1].X, Triangle[1].Y);
            Color v2color = baseColorComputer.ComputeColor(Triangle[2].X, Triangle[2].Y);

            return Color.FromArgb
            (
                (int)Math.Min(Math.Max(v0color.A * v0influence + v1color.A * v1influence + v2color.A * v2influence, 0), 255),
                (int)Math.Min(Math.Max(v0color.R * v0influence + v1color.R * v1influence + v2color.R * v2influence, 0), 255),
                (int)Math.Min(Math.Max(v0color.G * v0influence + v1color.G * v1influence + v2color.G * v2influence, 0), 255),
                (int)Math.Min(Math.Max(v0color.B * v0influence + v1color.B * v1influence + v2color.B * v2influence, 0), 255)
            );

        }
    }
}
