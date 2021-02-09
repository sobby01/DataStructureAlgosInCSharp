using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Matrix
{
    public class CalculatePrefixSum
    {
        int[][] prefixSum;
        public CalculatePrefixSum(int[][] matrix)
        {
            if (!matrix.Any())
            {
                    return;
            }
            int rowLength = matrix.GetLength(0);
            int colLength = matrix[0].Length;
            prefixSum = new int[rowLength+1][];
            prefixSum[0] = new int[colLength + 1];
            for (int i = 0; i < rowLength; i++)
            {
                prefixSum[i+1] = new int[colLength+1];
                prefixSum[i+1][1] = matrix[i][0];
                for (int j = 1; j < colLength; j++)
                {
                    prefixSum[i+1][j+1] = prefixSum[i+1][j] + matrix[i][j];
                }
            }

            for (int i = 0; i < colLength; i++)
            {
                for (int j = 1; j < rowLength; j++)
                {
                    prefixSum[j+1][i+1] = prefixSum[j][i+1] + prefixSum[j+1][i+1];
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            int sum = 0;
            if (prefixSum != null && prefixSum.GetLength(0) > 0)
            {
                sum = prefixSum[row2+1][col2+1] - prefixSum[row1][col2+1] - prefixSum[row2+1][col1] +
                prefixSum[row1][col1];
            }

            return sum;
        }
    }
}
