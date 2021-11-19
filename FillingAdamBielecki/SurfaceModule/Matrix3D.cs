using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public struct Matrix3D
    {
        private double[,] matrix;
        public Matrix3D(double[,] matrix)
        {
            if (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3)
            {
                throw new ArgumentException("Wrong matrix dimensions");
            }
            this.matrix = matrix;
        }
        public Matrix3D(Vector3D v0, Vector3D v1, Vector3D v2)
        {
            matrix = new double[3, 3];
            matrix[0, 0] = v0.X;
            matrix[1, 0] = v0.Y;
            matrix[2, 0] = v0.Z;
            matrix[0, 1] = v1.X;
            matrix[1, 1] = v1.Y;
            matrix[2, 1] = v1.Z;
            matrix[0, 2] = v2.X;
            matrix[1, 2] = v2.Y;
            matrix[2, 2] = v2.Z;

        }
        public double this[int index1, int index2] => matrix[index1,index2];

        public override string ToString()
        {
            return $"{matrix[0, 0]} {matrix[0, 1]} {matrix[0, 2]}\n{matrix[1, 0]} {matrix[1, 1]} {matrix[1, 2]}\n{matrix[2, 0]} {matrix[2, 1]} {matrix[2, 2]}";
        }
    }
}
