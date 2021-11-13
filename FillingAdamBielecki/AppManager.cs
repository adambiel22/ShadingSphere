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
        public bool IsInterpolation
        { 
            get => isInterpolation;
            set
            {
                isInterpolation = value;
                if (value)
                {
                    activePainter = triangleInterpolationPainter;
                }
                else
                {
                    activePainter = casualPainter;
                }
                Paint();
            }
        }

        public bool IsWithoutNormalMap
        {
            get => isWithoutNormalMap;
            set
            {
                if (value)
                {
                    surfaceSettings.SurfaceGeometryComputer = withoutSurfaceGeometryComputer;
                    Paint();
                }
                else
                {
                    surfaceSettings.SurfaceGeometryComputer = combineSurfaceGeometryComputer;
                    Paint();
                }
            }
        }
        public Bitmap NormalMap
        {
            get => normalMapGeometry.NormalMap;
            set
            {
                normalMapGeometry.NormalMap = value;
                Paint();
            }
        }
        
        public int TriangulationLevel 
        { 
            get => triangulation.N; 
            set
            {
                triangulation = new SphereTriangulation(value, R, midPoint);
                Paint();
            } 
        }
        public bool IsGrid
        { 
            get => isGrid;
            set
            {
                isGrid = value;
                Paint();
            }
        }
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
            triangulation = new SphereTriangulation(4, R, midPoint);
            isGrid = true;
            
            isWithoutNormalMap = true;
            withoutSurfaceGeometryComputer = new HalfSphereGeometry(R, midPoint);
            normalMapGeometry = new NormalMapGeometry(Properties.Resources.Bricks);
            combineSurfaceGeometryComputer = new CombineNormalGeometry(withoutSurfaceGeometryComputer, normalMapGeometry);
            ISurfaceGeometryComputer surfaceGeometryComputer = withoutSurfaceGeometryComputer;
            
            surfaceSettings = new SurfaceSettings(0.5, 0.8, Color.Red, Properties.Resources.landscape, true, 40, surfaceGeometryComputer);
            FPoint3D lightStartPosition = new FPoint3D(midPoint.X, midPoint.Y, 500);
            lightSource = new LightSource(lightStartPosition, Color.White);
            colorComputer = new ReflexColorComputer(surfaceSettings, lightSource);

            bitmapManager = new LockBitmap();
            casualPainter = new MyPainter(bitmapManager, colorComputer);
            triangleInterpolationPainter = new TriangleInterpolationPainter(bitmapManager, colorComputer);
            isInterpolation = false;
            activePainter = casualPainter;

            lightSourceMover = new SpiralLightSourceMover(lightStartPosition, 10 * Math.PI / 180, 50,
                50, 720, lightSource, Paint, 10);
        }

        public void Paint()
        {
            Bitmap triangulationVisualization = new Bitmap(PictureBox.Width, PictureBox.Height, PixelFormat.Format32bppArgb);
            bitmapManager.StartDrawing(triangulationVisualization);
            triangulation.FillTriangulation(activePainter.FillPolygon);
            if (IsGrid)
            {
                triangulation.DrawTriangulation(
                    (Point p1, Point p2) => activePainter.DrawLine(p1, p2, gridColor));
            }
            bitmapManager.EndDrawing();
            PictureBox.Image = triangulationVisualization;
        }

        private SphereTriangulation triangulation;
        private bool isGrid;
        private BitmapManager bitmapManager;
        private Painter activePainter;
        private MyPainter casualPainter;
        private TriangleInterpolationPainter triangleInterpolationPainter;
        private bool isInterpolation;
        private IColorComputer colorComputer;
        private SurfaceSettings surfaceSettings;
        private LightSource lightSource;
        private ISurfaceGeometryComputer withoutSurfaceGeometryComputer;
        private CombineNormalGeometry combineSurfaceGeometryComputer;
        private bool isWithoutNormalMap;
        private NormalMapGeometry normalMapGeometry;
        private LightSourceMover lightSourceMover;
        private bool isAnimation;

        private int R = 300;
        private Color gridColor = Color.Black;
        private Point midPoint;
    }
}
