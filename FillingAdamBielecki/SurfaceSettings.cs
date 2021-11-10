using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filling
{
    public class SurfaceSettings
    {
        public double K_d { get; set; }
        public double K_s { get; set; }
        public Color SurfaceColor { get; set; }
        public int M { get; set; }

        public SurfaceSettings(double k_d, double k_s, Color surfaceColor, int m)
        {
            K_d = k_d;
            K_s = k_s;
            SurfaceColor = surfaceColor;
            M = m;
        }
    }
}
