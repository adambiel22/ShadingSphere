using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filling
{
    public static class DrawingLine
    {
        public static void DrawLine(Point p1, Point p2, Action<int, int, Color> putPixel, Color color)
        {
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;
            int x = p1.X;
            int y = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;

            putPixel(x, y, color);
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
                    putPixel(x, y, color);
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
                    putPixel(x, y, color);
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
                    putPixel(x, y, color);
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
                    putPixel(x, y, color);
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
                    putPixel(x, y, color);
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
                    putPixel(x, y, color);
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
                    putPixel(x, y, color);
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
                    putPixel(x, y, color);
                }
            }
        }
    }
}
