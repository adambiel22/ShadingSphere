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
        public int FPS { get => 1000 / timer.Interval; 
            set
            {
                timer.Enabled = false; timer.Interval = 1000 / value; timer.Enabled = true; } }
        public int MinTime { get; set; }
        public int MaxTime { get; set; }
        public LightSource LightSource { get; set; }
        public Action PaintFrame { get; set; }

        public LightSourceMover(FPoint3D startingPoint, double velocity, int fps, LightSource lightSource, Action paintFrame)
        {
            timer = new Timer();
            StartingPoint = startingPoint;
            Velocity = velocity;
            FPS = fps;
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
        protected abstract void NextFrame(object sender, EventArgs e);

        protected abstract void Move();

        private Timer timer;
    }
}
