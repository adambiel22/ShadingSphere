using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public class TriangleInterpolationPainter : Painter
    {
        public TriangleInterpolationPainter(IPixelSetter pixelSetter, IColorComputer colorComputer, IPainterCreator painterCreator) 
            : base(pixelSetter, colorComputer)
        {
            this.painterCreator = painterCreator;
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
            Painter painter = painterCreator.CreatePainter(PixelSetter, triangleColorComputer);
            painter.FillPolygon(polygon);
        }

        public override void DrawLine(Point point1, Point point2, Color color)
        {
            Painter painter = painterCreator.CreatePainter(PixelSetter, ColorComputer);
            painter.DrawLine(point1, point2, color);
        }

        private IPainterCreator painterCreator;
    }
}
