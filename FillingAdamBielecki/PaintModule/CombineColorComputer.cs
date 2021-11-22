using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public class CombineColorComputer : IColorComputer
    {
        IColorComputer ColorComputer1 { get; set; }
        IColorComputer ColorComputer2 { get; set; }

        public CombineColorComputer(IColorComputer colorComputer1, IColorComputer colorComputer2)
        {
            ColorComputer1 = colorComputer1;
            ColorComputer2 = colorComputer2;
        }
        public Color ComputeColor(int x, int y)
        {
            Color color1 = ColorComputer1.ComputeColor(x, y);
            Color color2 = ColorComputer2.ComputeColor(x, y);
            return Color.FromArgb(
                Math.Min((int)color1.A + (int)color2.A, 255),
                Math.Min((int)color1.R + (int)color2.R, 255),
                Math.Min((int)color1.G + (int)color2.G, 255),
                Math.Min((int)color1.B + (int)color2.B, 255)
                );
        }
    }
}
