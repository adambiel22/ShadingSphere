using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace Filling
{
    public partial class Form1 : Form
    {
        SphereTriangulation sphereTriangulation;
        SurfaceSettings surfaceSettings;
        LightSource lightSource;
        SpiralLightSourceMover mover;
        int r = 300;
        Point midPoint;
        int time;

        public Form1()
        {
            InitializeComponent();
            pictureBox.MouseDown += PictureBox_MouseDown;

            k_sTrackBar.Value = 58;
            k_dTrackBar.Value = 50;
            triangulationTrackBar.Value = 4;
            time = 0;
            lightSourceTimer.Interval = 10;

            midPoint = new Point(pictureBox.Width / 2, pictureBox.Height / 2);
            Vector3D lightSourcePosition = new Vector3D(midPoint.X, midPoint.Y, r + 1000);
            lightSource = new LightSource(lightSourcePosition, Color.White);
            mover = new SpiralLightSourceMover(lightSourcePosition, Math.PI / 5, 20);
            surfaceSettings = new SurfaceSettings((double)k_dTrackBar.Value / k_dTrackBar.Maximum, (double)k_sTrackBar.Value / k_sTrackBar.Maximum, Color.Red, mTrackBar.Value);
            sphereTriangulation = new SphereTriangulation(triangulationTrackBar.Value, r, midPoint);

            k_dLabel.Text = ((double)k_dTrackBar.Value / k_dTrackBar.Maximum).ToString();
            triangulationLabel.Text = triangulationTrackBar.Value.ToString();
            mLabel.Text = mTrackBar.Value.ToString();
            k_sLabel.Text = ((double)k_sTrackBar.Value / k_sTrackBar.Maximum).ToString();

            paintSphere();
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(e.Location);
        }

        private void paintSphere()
        {
            Bitmap triangulationVisualization = new Bitmap(pictureBox.Width, pictureBox.Height, PixelFormat.Format32bppArgb);
            LockBitmap lockBitmap = new LockBitmap(triangulationVisualization);
            lockBitmap.LockBits();

            sphereTriangulation.FillTriangulation((Point[] triangle) => {
                FillingAlgorithm.FillPolygon(triangle, lockBitmap.SetPixel,
                    (int x, int y) => {
                        return NormalVectors.ReflexColor(
        lightSource.LightColor,
        surfaceSettings.SurfaceColor,
        NormalVectors.SphereHalfNormalVector(x, y, sphereTriangulation.R, sphereTriangulation.MidPoint),
        new Vector3D(x, y, NormalVectors.SphereZ(x, y, sphereTriangulation.R, sphereTriangulation.MidPoint)),
        lightSource.Position,
        surfaceSettings.K_d, surfaceSettings.K_s, surfaceSettings.M);
                    });
            });
            sphereTriangulation.DrawTriangulation(
                (Point p1, Point p2) =>
                { DrawingLine.DrawLine(p1, p2, lockBitmap.SetPixel, Color.Black); });
            lockBitmap.UnlockBits();
            pictureBox.Image = triangulationVisualization;
        }

        private void k_dTrackBar_Scroll(object sender, EventArgs e)
        {
            surfaceSettings.K_d = (double)k_dTrackBar.Value / k_dTrackBar.Maximum;
            k_dLabel.Text = ((double)k_dTrackBar.Value / k_dTrackBar.Maximum).ToString();
            paintSphere();
        }

        private void triangulationTrackBar_Scroll(object sender, EventArgs e)
        {
            sphereTriangulation = new SphereTriangulation(triangulationTrackBar.Value, r, midPoint);
            triangulationLabel.Text = triangulationTrackBar.Value.ToString();
            paintSphere();
        }

        private void k_sTrackBar_Scroll(object sender, EventArgs e)
        {
            surfaceSettings.K_s = (double)k_sTrackBar.Value / k_sTrackBar.Maximum;
            k_sLabel.Text = ((double)k_sTrackBar.Value / k_sTrackBar.Maximum).ToString();
            paintSphere();
        }

        private void mTrackBar_Scroll(object sender, EventArgs e)
        {
            surfaceSettings.M = mTrackBar.Value;
            mLabel.Text = mTrackBar.Value.ToString();
            paintSphere();
        }

        private void lightSourceTimer_Tick(object sender, EventArgs e)
        {
            time = (time + 1) % 720;
            mover.Move(lightSource, time);
            Debug.WriteLine("Move!");
            Debug.WriteLine(lightSource.Position);
            paintSphere();
        }
    }
}
