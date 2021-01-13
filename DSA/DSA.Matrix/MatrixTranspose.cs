using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Matrix
{
    public class MatrixTranspose
    {
        public void Transpose(int[,] matrix)
        {
            int n = matrix.Length;
            for(int i = 0; i < n; i++)
            {
                for(int j = 1; j < n; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = matrix[i, j];
                }
            }
        }
    }
}
