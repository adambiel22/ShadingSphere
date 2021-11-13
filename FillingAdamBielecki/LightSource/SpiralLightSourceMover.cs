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
        public SpiralLightSourceMover(FPoint3D startingPoint, double velocity, int fps, 
            int minTime, int maxTime, LightSource lightSource, 
            Action paintFrame, double spiralFactor) : base(startingPoint, velocity, fps, minTime, maxTime, lightSource, paintFrame)
        {
            SpiralFactor = spiralFactor;
        }

        protected override void Move()
        {
            LightSource.Position = new FPoint3D(
                SpiralFactor * time * Velocity * Math.Cos(time * Velocity) + StartingPoint.X,
                SpiralFactor * time * Velocity * Math.Sin(time * Velocity) + StartingPoint.Y,
                StartingPoint.Z);
        }

    }
}
