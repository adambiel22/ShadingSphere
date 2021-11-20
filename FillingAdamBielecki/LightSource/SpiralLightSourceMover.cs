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
            double angle = time * Velocity;

            LightSource.Position = new FPoint3D(
                SpiralFactor * angle * Math.Cos(angle) + StartingPoint.X,
                SpiralFactor * angle * Math.Sin(angle) + StartingPoint.Y,
                StartingPoint.Z);
        }

    }
}
