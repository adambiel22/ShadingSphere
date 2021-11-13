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
        public double this[int index1, int index2] => matrix[index1,index2];

        public override string ToString()
        {
            return $"{matrix[0, 0]} {matrix[0, 1]} {matrix[0, 2]}\n{matrix[1, 0]} {matrix[1, 1]} {matrix[1, 2]}\n{matrix[2, 0]} {matrix[2, 1]} {matrix[2, 2]}";
        }
    }
}
