using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public interface IPainterCreator
    {
        public Painter CreatePainter(IPixelSetter pixelSetter, IColorComputer colorComputer);
    }
}
