using System;
using System.Drawing;
using System.Windows.Forms;
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
        public void SetObjectBackgroundImage(Bitmap objectBackgroundImage)
        {
            surfaceSettings.SetSurfaceBitmap(objectBackgroundImage);
            Paint();
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
                    surfaceSettings.SurfaceGeometryComputer = professorNormalMapOnSphereGeometry;
                    Paint();
                }
            }
        }
        public void SetNormalMap(Bitmap normalMap)
        {
            normalMapGeometry.SetNormalMap(normalMap);
            Paint();
        }


        public double K
        {
            get => professorNormalMapOnSphereGeometry.K;
            set
            {
                professorNormalMapOnSphereGeometry.K = value;
                Paint();
            }
        }
        
        public int TriangulationLevel 
        { 
            get => triangulation.N; 
            set
            {
                triangulation = 
                    new MovableSphereTriangulation(value, R, midPoint, PictureBox, sensitiveness, Paint);
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
                lightSourceMover.StartingPoint =
                    new Vector3D(midPoint.X, midPoint.Y, value);
                lightSource.Position =
                    new Vector3D(midPoint.X, midPoint.Y, value);
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
        
        public AppManager(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
            midPoint = new Point(PictureBox.Width / 2, PictureBox.Height / 2);
            sensitiveness = 10;
            triangulation = new MovableSphereTriangulation(4, R, midPoint, pictureBox, sensitiveness, Paint);
            isGrid = true;
            
            isWithoutNormalMap = true;
            withoutSurfaceGeometryComputer = new HalfSphereGeometry(R, midPoint);
            normalMapGeometry = new NormalMapGeometry(Properties.Resources.Bricks, new LockBitmapCreator());
            professorNormalMapOnSphereGeometry = new ProfessorNormalMapOnSphereGeometry(
                    withoutSurfaceGeometryComputer, normalMapGeometry, 0.5);
            ISurfaceGeometryComputer surfaceGeometryComputer = withoutSurfaceGeometryComputer;
            
            surfaceSettings = new SurfaceSettings(0.5, 0.8, Color.Red,
                Properties.Resources.landscape, true, 40, surfaceGeometryComputer);
            Vector3D lightStartPosition = new Vector3D(midPoint.X, midPoint.Y, 500);
            lightSource = new LightSource(lightStartPosition, Color.White);
            colorComputer = new ReflexColorComputer(surfaceSettings, lightSource);

            bitmapManager = new LockBitmap();
            casualPainter = new MyPainter(bitmapManager, colorComputer);
            triangleInterpolationPainter = new TriangleInterpolationPainter(bitmapManager, colorComputer);
            isInterpolation = false;
            activePainter = casualPainter;

            lightSourceMover = new SpiralLightSourceMover(lightStartPosition, 5 * Math.PI / 180, 40,
                36, 36*15, lightSource, Paint, 20);
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
        private HalfSphereGeometry withoutSurfaceGeometryComputer;
        private ProfessorNormalMapOnSphereGeometry professorNormalMapOnSphereGeometry;
        private bool isWithoutNormalMap;
        private NormalMapGeometry normalMapGeometry;
        private LightSourceMover lightSourceMover;
        private bool isAnimation;

        private int R = 300;
        private int sensitiveness;
        private Color gridColor = Color.Black;
        private Point midPoint;
    }
}
