using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public class TriangleInterpolationPainter : MyPainter
    {
        public TriangleInterpolationPainter(IPixelSetter pixelSetter, IColorComputer colorComputer) 
            : base(pixelSetter, colorComputer)
        {
            triangleInterpolationColorComputer = new TriangleInterpolationColorComputer(colorComputer);
            base.ColorComputer = triangleInterpolationColorComputer;
        }

        public override void FillPolygon(Point[] polygon)
        {
            if (polygon.Length != 3)
            {
                throw new ArgumentException("Filled polygon should be a triangle");
            }
            triangleInterpolationColorComputer.Triangle = polygon;
            base.FillPolygon(polygon);
        }

        private TriangleInterpolationColorComputer triangleInterpolationColorComputer;
    }
}
