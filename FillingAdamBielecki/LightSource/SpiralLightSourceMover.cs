using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    class SpiralLightSourceMover : LightSourceMover
    {
        public double SpiralFactor { get; set; }

        public SpiralLightSourceMover(FPoint3D startingPoint, double velocity, double spiralFactor) : base(startingPoint, velocity)
        {
            SpiralFactor = spiralFactor;
        }

        public override void Move(LightSource lightSource, int time)
        {
            lightSource.Position = new FPoint3D(
                SpiralFactor * time * Velocity * Math.Cos(time * Velocity) + StartingPoint.X,
                SpiralFactor * time * Velocity * Math.Sin(time * Velocity) + StartingPoint.Y,
                StartingPoint.Z);
        }

    }
}
