using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filling
{
    public abstract class LightSourceMover
    {
        public FPoint3D StartingPoint { get; set; }
        public double Velocity { get; set; }
        public int FPS { get => 1000 / timer.Interval; set { timer.Interval = 1000 / value; } }
        public int MinTime { get; set; }
        public int MaxTime { get; set; }
        public LightSource LightSource { get; set; }
        public Action PaintFrame { get; set; }

        public LightSourceMover(FPoint3D startingPoint, double velocity, int fps,
            int minTime, int maxTime, LightSource lightSource, Action paintFrame)
        {
            timer = new Timer();
            StartingPoint = startingPoint;
            Velocity = velocity;
            FPS = fps;
            MinTime = minTime;
            MaxTime = maxTime;
            time = minTime;
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

        protected int time;
        private Timer timer;
    }
}
