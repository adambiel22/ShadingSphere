using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public class MyPainter : Painter
    {
        public MyPainter(IPixelSetter pixelSetter, IColorComputer colorComputer) 
            : base(pixelSetter, colorComputer)
        {
        }

        
        public override void FillPolygon(Point[] points)
        {
            int n = points.Length;
            int[] ind = new int[n];
            ActiveEdge[] edges = new ActiveEdge[n];
            List<ActiveEdge> AET = new List<ActiveEdge>();

            for (int i = 0; i < n; i++)
            {
                ind[i] = i;
                edges[i] = new ActiveEdge(points[i], points[(i + 1) % n], i);
            }
            Array.Sort(ind, (int i, int j) => {
                return points[i].Y - points[j].Y == 0 ? 0 :
                (points[i].Y - points[j].Y < 0 ? -1 : 1);
            });

            int k = 0;
            for (int y = points[ind[0]].Y + 1; y <= points[ind[n - 1]].Y; y++)
            {
                while (points[ind[k]].Y == y - 1)
                {
                    Point p = points[(ind[k] + n - 1) % n];
                    if (p.Y > points[ind[k]].Y)
                    {
                        AET.Add(edges[(ind[k] + n - 1) % n]);
                    }
                    else if (p.Y < points[ind[k]].Y)
                    {
                        AET.Remove(edges[(ind[k] + n - 1) % n]);
                    }

                    p = points[(ind[k] + 1) % n];
                    if (p.Y > points[ind[k]].Y)
                    {
                        AET.Add(edges[ind[k]]);
                    }
                    else if (p.Y < points[ind[k]].Y)
                    {
                        AET.Remove(edges[ind[k]]);
                    }
                    k++;
                }

                AET.Sort();
                for (int i = 0; i < AET.Count; i += 2)
                {
                    for (int x = (int)AET[i].X + 1; x < AET[(i + 1)].X; x++)
                    {
                        PixelSetter.SetPixel(x, y, ColorComputer.ComputeColor(x, y));
                    }
                }

                foreach (var i in AET)
                {
                    i.Increment();
                }
            }
        }

        public override void DrawLine(Point p1, Point p2, Color color)
        {
            
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;
            int x = p1.X;
            int y = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;

            PixelSetter.SetPixel(x, y, color);
            //[0, pi/4)
            if (dx > 0 && dy >= 0 && dy < dx)
            {
                int d = 2 * dy - dx;
                int incrE = 2 * dy;
                int incrNE = 2 * (dy - dx);

                while (x < x2)
                {
                    x++;
                    if (d < 0)
                    {
                        d += incrE;
                    }
                    else
                    {
                        d += incrNE;
                        y++;
                    }
                    PixelSetter.SetPixel(x, y, color);
                }
            }
            //[pi/4, pi/2)
            else if (dx > 0 && dy > 0 && dy >= dx)
            {
                int d = dy - 2 * dx;
                int incrN = -2 * dx;
                int incrNE = 2 * (dy - dx);

                while (y < y2)
                {
                    y++;
                    if (d > 0)
                    {
                        d += incrN;
                    }
                    else
                    {
                        d += incrNE;
                        x++;
                    }
                    PixelSetter.SetPixel(x, y, color);
                }
            }
            //[pi/2, 3pi/4)
            else if (dx <= 0 && dy > 0 && dy >= -dx)
            {
                int d = -dy - 2 * dx;
                int incrN = -2 * dx;
                int incrNW = -2 * dy - 2 * dx;

                while (y < y2)
                {
                    y++;
                    if (d < 0)
                    {
                        d += incrN;
                    }
                    else
                    {
                        d += incrNW;
                        x--;
                    }
                    PixelSetter.SetPixel(x, y, color);
                }
            }
            //[3pi/4, pi)
            else if (dx < 0 && dy > 0 && dy <= -dx)
            {
                int d = -2 * dy - dx;
                int incrW = -2 * dy;
                int incrNW = -2 * dy - 2 * dx;

                while (x > x2)
                {
                    x--;
                    if (d > 0)
                    {
                        d += incrW;
                    }
                    else
                    {
                        d += incrNW;
                        y++;
                    }
                    PixelSetter.SetPixel(x, y, color);
                }
            }
            //[pi, 5pi/4)
            else if (dx < 0 && dy <= 0 && dy > dx)
            {
                int d = -2 * dy + dx;
                int incrW = -2 * dy;
                int incrSW = -2 * dy + 2 * dx;

                while (x > x2)
                {
                    x--;
                    if (d < 0)
                    {
                        d += incrW;
                    }
                    else
                    {
                        d += incrSW;
                        y--;
                    }
                    PixelSetter.SetPixel(x, y, color);
                }
            }
            //[5pi/4, 3pi/2)
            else if (dx < 0 && dy < 0 && dy <= dx)
            {
                int d = -dy + 2 * dx;
                int incrS = 2 * dx;
                int incrSW = -2 * dy + 2 * dx;

                while (y > y2)
                {
                    y--;
                    if (d > 0)
                    {
                        d += incrS;
                    }
                    else
                    {
                        d += incrSW;
                        x--;
                    }
                    PixelSetter.SetPixel(x, y, color);
                }
            }
            //[3pi/2, 7pi/4)
            else if (dx >= 0 && dy < 0 && -dy > dx)
            {
                int d = dy + 2 * dx;
                int incrS = 2 * dx;
                int incrSE = 2 * dy + 2 * dx;

                while (y > y2)
                {
                    y--;
                    if (d < 0)
                    {
                        d += incrS;
                    }
                    else
                    {
                        d += incrSE;
                        x++;
                    }
                    PixelSetter.SetPixel(x, y, color);
                }
            }
            //[7pi/4, 2pi)
            else if (dx > 0 && dy < 0 && -dy <= dx)
            {
                int d = 2 * dy + dx;
                int incrE = 2 * dy;
                int incrSE = 2 * dy + 2 * dx;

                while (x < x2)
                {
                    x++;
                    if (d > 0)
                    {
                        d += incrE;
                    }
                    else
                    {
                        d += incrSE;
                        y--;
                    }
                    PixelSetter.SetPixel(x, y, color);
                }
            }
        }

        private class ActiveEdge : IComparable<ActiveEdge>
        {
            public int Ymax { get; }
            public double X { get; private set; }
            public double XIncrement { get; }
            public int Id { get; }

            public ActiveEdge(Point p1, Point p2, int id)
            {
                Ymax = Math.Max(p1.Y, p2.Y);
                X = p1.Y < p2.Y ? p1.X : p2.X;
                XIncrement = p1.Y == p2.Y ? 0 : (double)(p1.X - p2.X) / (p1.Y - p2.Y);
                Id = id;
            }

            public void Increment()
            {
                X += XIncrement;
            }

            public int CompareTo(ActiveEdge other)
            {
                return this.X - other.X == 0 ? 0 :
                (this.X - other.X < 0 ? -1 : 1);
            }
        }
    }
}
