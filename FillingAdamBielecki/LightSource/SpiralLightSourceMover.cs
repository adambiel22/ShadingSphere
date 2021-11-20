using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Filling
{
    class SpiralLightSourceMover : LightSourceMover
    {
        public double SpiralFactor { get; set; }

        public SpiralLightSourceMover(FPoint3D startingPoint, double angularVelocity,
            int fps, LightSource lightSource, Action paintFrame, double minAngle, double maxAngle, double spiralFactor)
            : base(startingPoint, angularVelocity, fps, lightSource, paintFrame)
        {
            this.minAngle = minAngle * Math.PI / 180;
            this.maxAngle = maxAngle * Math.PI / 180;
            angle = this.minAngle;
            SpiralFactor = spiralFactor;
        }

        protected override void Move()
        {
            //LightSource.Position = new FPoint3D(
            //    SpiralFactor * angle * Math.Cos(angle) + StartingPoint.X,
            //    SpiralFactor * angle * Math.Sin(angle) + StartingPoint.Y,
            //    StartingPoint.Z);
            LightSource.Position = new FPoint3D(
    Math.Pow(SpiralFactor, angle) * Math.Cos(angle) + StartingPoint.X,
    Math.Pow(SpiralFactor, angle) * Math.Sin(angle) + StartingPoint.Y,
    StartingPoint.Z);
        }

        protected override void NextFrame(object sender, EventArgs e)
        {
            angle = minAngle + ((angle + (Velocity * Math.PI / 180 / FPS)) - minAngle) % (maxAngle - minAngle) ;
            Move();
            PaintFrame();
        }

        private double angle;
        private double minAngle;
        private double maxAngle;
        private TimeSpan prevTimeSpan = TimeSpan.Zero;
        private Stopwatch stopwatch = new Stopwatch();
    }
}