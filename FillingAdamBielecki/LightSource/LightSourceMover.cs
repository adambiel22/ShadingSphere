using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Filling
{
    public abstract class LightSourceMover
    {
        public Vector3D StartingPoint { get; set; }
        public double Velocity { get; set; }
        public int FPS
        {
            get => 1000 / timer.Interval;
            set
            {
                timer.Interval = 1000 / value;
            }
        }
        public double MinTime { get; set; }
        public double MaxTime { get; set; }
        public LightSource LightSource { get; set; }
        public Action PaintFrame { get; set; }

        public LightSourceMover(Vector3D startingPoint, double velocity, int fps,
            double minTime, double maxTime, LightSource lightSource, Action paintFrame)
        {
            timer = new Timer();
            StartingPoint = startingPoint;
            Velocity = velocity;
            FPS = fps;
            MinTime = minTime;
            MaxTime = maxTime;
            time = MinTime;
            LightSource = lightSource;
            timer.Tick += NextFrame;
            PaintFrame = paintFrame;
        }
        public void StartAnimation()
        {
            timer.Enabled = true;
        }
        public void StopAnimation()
        {
            timer.Enabled = false;
        }
        private void NextFrame(object sender, EventArgs e)
        {
            time = MinTime + (time - MinTime + 1) % (MaxTime - MinTime + 1);
            Move();
            PaintFrame();
        }
        protected abstract void Move();

        protected double time;
        private Timer timer;
    }
}
