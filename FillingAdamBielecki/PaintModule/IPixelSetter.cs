using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filling
{
    public interface IPixelSetter
    {
        public void SetPixel(int x, int y, Color color);
    }
}
