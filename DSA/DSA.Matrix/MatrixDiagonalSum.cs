using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Matrix
{
    public class MatrixDiagonalSum
    {
        public int DiagonalSum(int[][] mat)
        {
            int rowLen = mat.GetLength(0);
            //int colLen = mat.GetLength(1);

            int diagonalSum = 0;

            for(int i = 0; i < rowLen; i++)
            {
                diagonalSum += mat[i][i];
            }

            int highValue = rowLen - 1;
            for (int i = 0; i < rowLen; i++)
            {
                if(i != highValue)
                    diagonalSum += mat[i][highValue];

                highValue--;
            }

            return diagonalSum;
        }
    }
}
