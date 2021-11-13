using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filling
{
    public abstract class Painter
    {
        public abstract void DrawLine(Point point1, Point point2, Color color);
        public abstract void FillPolygon(Point[] polygon);
        public IPixelSetter PixelSetter { get; set; }
        public IColorComputer ColorComputer { get; set; }

        public Painter(IPixelSetter pixelSetter, IColorComputer colorComputer)
        {
            PixelSetter = pixelSetter;
            ColorComputer = colorComputer;
        }
    }
}
