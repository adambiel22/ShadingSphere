using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filling
{
    public class LightSource
    {
        public FPoint3D Position { get; set; }
        public Color LightColor { get; set; }

        public LightSource(FPoint3D position, Color lightColor)
        {
            Position = position;
            LightColor = lightColor;
        }
        public LightSource(Color lightColor)
        {
            LightColor = lightColor;
        }
    }
}
