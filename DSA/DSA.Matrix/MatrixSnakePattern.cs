using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Matrix
{
    public class MatrixSnakePattern
    {
        public void PrintPattern(int[,] matrix)
        {
            //For Row Length
            int rowLength = matrix.GetLength(0);
            //For Column Length
            int colLength = matrix.GetLength(1);

            for(int i = 0; i < rowLength; i++)
            {

                if((i & (i-1)) == 0)
                {
                    for(int j = 0; j < colLength; j++)
                    {
                        Console.WriteLine(matrix[i,j]);
                    }
                }
                else
                {
                    for (int j = colLength-1; j >= 0; j--)
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                }
            }
            
        }
    }
}
