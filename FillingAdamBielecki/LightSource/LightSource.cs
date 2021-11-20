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
        public Vector3D Position { get; set; }
        public Color Color { get; set; }

        public LightSource(Vector3D position, Color lightColor)
        {
            Position = position;
            Color = lightColor;
        }
        public LightSource(Color lightColor)
        {
            Color = lightColor;
        }
    }
}
