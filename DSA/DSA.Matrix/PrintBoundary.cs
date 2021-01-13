using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Matrix
{
    public class PrintBoundary
    {
        public void PrintB(int[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            if(rowLength == 1)
            {
                for(int i = 0; i < colLength - 1; i++)
                {
                    Console.Write(matrix[0, i]);
                }
            }
            else if (colLength == 1)
            {
                for (int i = 0; i < rowLength - 1; i++)
                {
                    Console.Write(matrix[i, 0]);
                }
            }
            else
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(matrix[0, j]);
                }
                for (int j = 1; j < colLength; j++)
                {
                    Console.Write(matrix[j, colLength - 1]);
                }
                for (int j = colLength - 2; j >= 0; j++)
                {
                    Console.Write(matrix[rowLength - 1, j]);
                }
                for (int j = rowLength - 2; j >= 0; j++)
                {
                    Console.Write(matrix[j, 0]);
                }
            }            
        }
    }
}
