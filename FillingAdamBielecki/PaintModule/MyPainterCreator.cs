using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public class MyPainterCreator : IPainterCreator
    {
        public Painter CreatePainter(IPixelSetter pixelSetter, IColorComputer colorComputer)
        {
            return new MyPainter(pixelSetter, colorComputer);
        }
    }
}
