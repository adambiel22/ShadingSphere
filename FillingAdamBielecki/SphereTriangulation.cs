using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filling
{
    public class SphereTriangulation
    {
        public int N { get; }
        public int R { get; }
        public Point MidPoint { get; }
        public SphereTriangulation(int n, int r, Point midPoint)
        {
            N = n;
            R = r;
            MidPoint = midPoint;
            generateTriangulation();
        }

        private void generateTriangulation()
        {
            triangles = new Point3D[(int)Math.Pow(4, N), 3];
            Point3D v_0 = new Point3D(0, 0, R);
            Point3D v_1 = new Point3D(R, 0, 0);
            Point3D v_2 = new Point3D(0, R, 0);
            Point3D v_3 = new Point3D(-R, 0, 0);
            Point3D v_4 = new Point3D(0, -R, 0);
            int tindex = 0;
            recursion(v_1, v_2, v_0, 1, ref tindex);
            recursion(v_2, v_3, v_0, 1, ref tindex);
            recursion(v_3, v_4, v_0, 1, ref tindex);
            recursion(v_4, v_1, v_0, 1, ref tindex);
            for (int i = 0; i < triangles.GetLength(0); i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    triangles[i,j] = triangles[i, j] + MidPoint;
                }
            }
        }

        private void recursion(Point3D v_0, Point3D v_1, Point3D v_2, int n, ref int tindex)
        {
            if (n == N)
            {
                triangles[tindex, 0] = v_0;
                triangles[tindex, 1] = v_1;
                triangles[tindex, 2] = v_2;
                tindex++;
                return;
            }

            Point3D w_0 = R * (v_0 + v_1) / Point3D.Dist(v_0 + v_1);
            Point3D w_1 = R * (v_1 + v_2) / Point3D.Dist(v_1 + v_2);
            Point3D w_2 = R * (v_2 + v_0) / Point3D.Dist(v_0 + v_1);

            recursion(v_0, w_0, w_2, n + 1, ref tindex);
            recursion(w_0, v_1, w_1, n + 1, ref tindex);
            recursion(w_2, w_1, v_2, n + 1, ref tindex);
            recursion(w_1, w_2, w_0, n + 1, ref tindex);
        }

        public void DrawTriangulation(Action<Point, Point> drawLine)
        {
            for (int i = 0; i < triangles.GetLength(0); i++)
            {
                for (int j = 0; j < 3; j++)
                {                    
                    drawLine(triangles[i, j], triangles[i, (j + 1) % 3]);
                }
            }
        }

        public void FillTriangulation(Action<Point[]> fillTriangle)
        {
            for (int i = 0; i < triangles.GetLength(0); i++)
            {
                fillTriangle(new Point[]
                {
                    triangles[i,0],
                    triangles[i,1],
                    triangles[i,2]
                });
            }
        }

        private Point3D[,] triangles;
    }
}
