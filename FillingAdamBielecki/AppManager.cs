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
    public class AppManager
    {
        public PictureBox PictureBox { get; set; }
        public Color ObjectBacgroundColor
        { 
            get => surfaceSettings.SurfaceColor;
            set { surfaceSettings.SurfaceColor = value; Paint(); } 
        }
        public Bitmap ObjectBackgroundImage
        { 
            get => surfaceSettings.SurfaceBitmap;
            set { surfaceSettings.SurfaceBitmap = value; Paint(); } 
        }
        public bool IsObjectPlain
        { 
            get => surfaceSettings.IsPlain;
            set { surfaceSettings.IsPlain = value; Paint(); }
        }
        public bool IsInterpolation { get; set; }

        public bool IsWithoutNormalMap { get; set; }
        public Image NormalMap { get; set; }
        
        public int TriangulationLevel 
        { 
            get => triangulation.N; 
            set
            {
                triangulation = new SphereTriangulation(value, R, new Point(PictureBox.Width / 2, PictureBox.Height / 2));
                Paint();
            } 
        }
        public bool IsGrid { get; set; }
        public double Kd 
        {
            get => surfaceSettings.K_d;
            set { surfaceSettings.K_d = value; Paint(); }
        }
        public double Ks
        {
            get => surfaceSettings.K_s;
            set { surfaceSettings.K_s = value; Paint(); }
        }
        public int M
        {
            get => surfaceSettings.M;
            set { surfaceSettings.M = value; Paint(); }
        }

        public Color LightColor
        {
            get => lightSource.Color;
            set { lightSource.Color = value; Paint(); }
        }
        public int Height
        {
            get => (int)lightSource.Position.Z;
            set
            {
                lightSource.Position =
                    new FPoint3D(lightSource.Position.X, lightSource.Position.Y, value);
                lightSourceMover.StartingPoint =
                    new FPoint3D(lightSource.Position.X, lightSource.Position.Y, value);
                Paint();
            } 
        }
        public bool IsAnimation
        {
            get => isAnimation;
            set
            {
                isAnimation = value;
                if (value)
                {
                    lightSourceMover.StartAnimation();
                }
                else
                {
                    lightSourceMover.StopAnimation();
                }
            } 
        }
        public int FPS
        { 
            get => lightSourceMover.FPS;
            set { lightSourceMover.FPS = value; }
        }
        public double Velocity { get => lightSourceMover.Velocity; set { lightSourceMover.Velocity = value; } }

        public AppManager(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
            midPoint = new Point(PictureBox.Width / 2, PictureBox.Height / 2);
            triangulation = new SphereTriangulation(5, R, midPoint);
            bitmapManager = new LockBitmap();
            //surfaceGeometryComputer = new HalfSphereGeometry(R, midPoint);
            //surfaceGeometryComputer = new NormalMapGeometry(new Bitmap(Properties.Resources.Bricks));
            surfaceGeometryComputer = new NormalMapOnSphereGeometry(new HalfSphereGeometry(R, midPoint), new NormalMapGeometry(new Bitmap(Properties.Resources.Radial)));
            surfaceSettings = new SurfaceSettings(0.5, 0.8, Color.Red, null, true, 40, surfaceGeometryComputer);
            FPoint3D lightStartPosition = new FPoint3D(midPoint.X, midPoint.Y, 500);
            lightSource = new LightSource(lightStartPosition, Color.White);
            colorComputer = new ReflexColorComputer(surfaceSettings, lightSource);
            painter = new MyPainter(bitmapManager, colorComputer);
            lightSourceMover = new SpiralLightSourceMover(lightStartPosition, 10 * Math.PI / 180, 50,
                100, 720, lightSource, Paint, 10);
        }

        public void Paint()
        {
            Bitmap triangulationVisualization = new Bitmap(PictureBox.Width, PictureBox.Height, PixelFormat.Format32bppArgb);
            bitmapManager.StartDrawing(triangulationVisualization);
            triangulation.FillTriangulation(painter.FillPolygon);
            if (IsGrid)
            {
                triangulation.DrawTriangulation(
                    (Point p1, Point p2) => painter.DrawLine(p1, p2, gridColor));
            }
            bitmapManager.EndDrawing();
            PictureBox.Image = triangulationVisualization;
        }

        private SphereTriangulation triangulation;
        private BitmapManager bitmapManager;
        private Painter painter;
        private IColorComputer colorComputer;
        private SurfaceSettings surfaceSettings;
        private LightSource lightSource;
        private ISurfaceGeometryComputer surfaceGeometryComputer;
        private LightSourceMover lightSourceMover;
        private bool isAnimation;

        private int R = 300;
        private Color gridColor = Color.Black;
        private Point midPoint;
    }
}
