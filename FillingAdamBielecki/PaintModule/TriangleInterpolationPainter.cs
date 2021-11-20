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
        }

        public override void FillPolygon(Point[] polygon)
        {
            if (polygon.Length != 3)
            {
                throw new ArgumentException("Filled polygon should be a triangle");
            }
            TriangleInterpolationColorComputer triangleColorComputer =
                new TriangleInterpolationColorComputer(ColorComputer);
            triangleColorComputer.Triangle = polygon;
            MyPainter painter = new MyPainter(PixelSetter, triangleColorComputer);
            painter.FillPolygon(polygon);
        }
    }
}
