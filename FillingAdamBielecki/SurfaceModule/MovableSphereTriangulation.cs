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
    public class MovableSphereTriangulation : SphereTriangulation 
    {
        public PictureBox PictureBox { get; set; }
        public int Sensitiveness { get; set; }
        public Action Paint { get; set; }

        public MovableSphereTriangulation(int n, int r, Point midPoint, PictureBox pictureBox,
            int sensitiveness, Action paint) : base(n, r, midPoint)
        {
            PictureBox = pictureBox;
            Sensitiveness = sensitiveness;
            PictureBox.MouseDown += PictureBox_MouseDown;
            Paint = paint;
        }


        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            movingVerticies = new List<(int, int)>();
            for (int i = 0; i < triangles.GetLength(0); i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((e.Location.X - triangles[i,j].X) * (e.Location.X - triangles[i, j].X) +
                        (e.Location.Y - triangles[i, j].Y) * (e.Location.Y - triangles[i, j].Y) < 
                        Sensitiveness * Sensitiveness)
                    {
                        movingVerticies.Add((i, j));
                    }
                }
            }
            PictureBox.MouseMove += PictureBox_MouseMove;
            PictureBox.MouseUp += PictureBox_MouseUp;
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            movingVerticies = null;
            PictureBox.MouseMove -= PictureBox_MouseMove;
            PictureBox.MouseUp -= PictureBox_MouseUp;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            foreach(var i in movingVerticies)
            {
                triangles[i.Item1, i.Item2] = new Vector3D(e.Location.X, e.Location.Y,
                    Math.Sqrt(R * R - (e.Location.X - MidPoint.X) * (e.Location.X - MidPoint.X) -
                     (e.Location.Y - MidPoint.Y) * (e.Location.Y - MidPoint.Y)));
            }
            Paint();
        }

        private List<(int, int)> movingVerticies; 
    }
}
