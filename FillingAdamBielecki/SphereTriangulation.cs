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
        }

        private void generateTriangulation()
        {
            verices = new Point3D[2 ^ N + 2 ^ (2 * N - 1) + 1];
            triangles = new int[4 ^ N, 3];
            verices[0] = new Point3D(0, 0, R);
            verices[1] = new Point3D(R, 0, 0);
            verices[2] = new Point3D(0, R, 0);
            verices[3] = new Point3D(-R, 0, 0);
            verices[4] = new Point3D(0, -R, 0);
            int vindex = 5;
            int tindex = 0;
            recursion(1, 2, 0, 1, ref vindex, ref tindex);
            recursion(2, 3, 0, 1, ref vindex, ref tindex);
            recursion(3, 4, 0, 1, ref vindex, ref tindex);
            recursion(4, 1, 0, 1, ref vindex, ref tindex);
        }

        private void recursion(int v_0, int v_1, int v_2, int n, ref int vindex, ref int tindex)
        {
            if (n == N)
            {
                triangles[tindex, 0] = v_0;
                triangles[tindex, 1] = v_1;
                triangles[tindex, 2] = v_2;
                tindex++;
                return;
            }
            Point3D w_0 = R*(verices[v_0] + verices[v_1])/;
            Point3D w_1 = 
            Point3D w_2 = 
        }

        public DrawTriangulation(Action<Point[]> drawTriangle)
        {

        }

        private Point3D[] verices;
        private int[,] triangles;
    }
}
