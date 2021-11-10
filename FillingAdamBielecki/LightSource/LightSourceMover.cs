using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public abstract class LightSourceMover
    {
        public FPoint3D StartingPoint { get; set; }
        public double Velocity { get; set; }
        public LightSourceMover(FPoint3D startingPoint, double velocity)
        {
            StartingPoint = startingPoint;
            Velocity = velocity;
        }
        public abstract void Move(LightSource lightSource, int time);
    }
}
