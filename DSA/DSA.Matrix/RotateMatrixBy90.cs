using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Matrix
{
    public class RotateMatrixBy90
    {
        public void Rotate90(int[,] matrix)
        {
            int rLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i< rLength; i++)
            {
                for(int j = i + 1; j < colLength; j++)
                {
                    int temp = matrix[i, j];

                    matrix[i, j] = matrix[j, i];

                    matrix[j, i] = temp;
                }
            }

            int high = rLength;

            for (int i = 0; i< rLength/2; i++)
            {
                int indexer = 0;

                high = high - 1;
                for (int j =0; j < colLength; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[high, j];
                    matrix[high, j] = temp;
                }
            }
        }
    }
}
