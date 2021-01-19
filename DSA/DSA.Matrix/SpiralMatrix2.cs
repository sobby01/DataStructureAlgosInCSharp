using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Matrix
{
    public class SpiralMatrix2
    {
        public List<List<int>> GenerateMatrix(int A)
        {
            List<List<int>> mat = new List<List<int>>();
            int[][] matrix = new int[A][];
            int matrixSize = A * A;
            int top = 0; int right = A - 1; int bottom = A - 1; int left = 0;
            int startNumber = 0;
            for (int i = 0; i < A; i++)
            {
                matrix[i] = new int[A];
            }
            while (top <= bottom && left <= right)
            {
                for (int i = top; i <= right; i++)
                {
                    matrix[left][i] = ++startNumber;
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    matrix[i][right] = ++startNumber;
                }

                right--;

                for (int i = right; i >= left; i--)
                {
                    matrix[bottom][i] = ++startNumber;
                }
                bottom--;

                for (int i = bottom; i >= top; i--)
                {
                    matrix[i][left] = ++startNumber;
                }

                left++;
            }

            for (int i = 0; i < A; i++)
            {
                List<int> abc = new List<int>();
                for (int j = 0; j < A; j++)
                {
                    abc.Add(matrix[i][j]);
                }

                mat.Add(abc);
            }

            return mat;
        }

        public int[][] GenerateMatrixWithArray(int A)
        {
            int[][] matrix = new int[A][];
            int matrixSize = A * A;
            int top = 0; int right = A - 1; int bottom = A - 1; int left = 0;
            int startNumber = 0;
            for(int i =0; i< A; i++)
            {
                matrix[i] = new int[A];
            }

            while (top <= bottom && left <= right)
            {
                for (int i = top; i <= right; i++)
                {
                    matrix[left][i] = ++startNumber;
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    matrix[i][right] = ++startNumber;
                }

                right--;

                for (int i = right; i >= left; i--)
                {
                    matrix[bottom][i] = ++startNumber;
                }
                bottom--;

                for (int i = bottom; i >= top; i--)
                {
                    matrix[i][left] = ++startNumber;
                }

                left++;
            }

            return matrix;
        }
    }
}
