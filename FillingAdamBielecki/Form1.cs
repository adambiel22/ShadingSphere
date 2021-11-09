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
        public Form1()
        {
            InitializeComponent();
            pictureBox.MouseDown += PictureBox_MouseDown;

            Bitmap triangulationVisualization = new Bitmap(pictureBox.Width, pictureBox.Height, PixelFormat.Format32bppArgb);
            LockBitmap lockBitmap = new LockBitmap(triangulationVisualization);
            lockBitmap.LockBits();
            SphereTriangulation triangulation = 
                new SphereTriangulation(4, 300, new Point(pictureBox.Width / 2, pictureBox.Height / 2));
            triangulation.DrawTriangulation(
                (Point p1, Point p2) => 
                { DrawingLine.DrawLine(p1, p2, lockBitmap.SetPixel, Color.Black); });
            lockBitmap.UnlockBits();
            triangulationVisualization.Save("triangulaion.bmp", ImageFormat.Bmp);
            pictureBox.Image = triangulationVisualization;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //Bitmap bitmap = new Bitmap(pictureBox.Image);
            //FastBitmap fastBitmap = new FastBitmap(bitmap);
            //fastBitmap.WriteLock(e.X, e.Y, 15, 15);
            //fastBitmap.ClearRectangle(Color.Red);
            //fastBitmap.UnlockBits();
            //bitmap.Save("bitmap.bmp", ImageFormat.Bmp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox.Image.Save("bitmap.bmp", ImageFormat.Bmp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            FPoint3D lightSourcePosition = new FPoint3D(pictureBox.Width / 2 + 100, pictureBox.Height / 2 + 100, 400);
            Bitmap triangulationVisualization = new Bitmap(pictureBox.Width, pictureBox.Height, PixelFormat.Format32bppArgb);
            LockBitmap lockBitmap = new LockBitmap(triangulationVisualization);
            lockBitmap.LockBits();
            SphereTriangulation triangulation =
                new SphereTriangulation(trackBar1.Value, 300, new Point(pictureBox.Width / 2, pictureBox.Height / 2));
            triangulation.FillTriangulation((Point[] triangle) => {
                FillingAlgorithm.FillPlainPolygon(triangle, lockBitmap.SetPixel, Color.Red); });
            triangulation.DrawTriangulation(
                (Point p1, Point p2) =>
                { DrawingLine.DrawLine(p1, p2, lockBitmap.SetPixel, Color.Black); });
            lockBitmap.UnlockBits();
            triangulationVisualization.Save("triangulaion.bmp", ImageFormat.Bmp);
            pictureBox.Image = triangulationVisualization;
        }
    }
}
