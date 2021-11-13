using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filling
{
    public interface IColorComputer
    {
        public Color ComputeColor(int x, int y);
    }
}
