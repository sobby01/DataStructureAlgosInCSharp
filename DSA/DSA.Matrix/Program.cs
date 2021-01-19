using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Matrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            SpiralMatrix2 sp2 = new SpiralMatrix2();
            sp2.GenerateMatrix(3);
            return;


            sp2.GenerateMatrixWithArray(3);
            return;



            int[][] matrix2 = new int[3][];

            matrix2[0] = new int[3];
            matrix2[1] = new int[3];
            matrix2[2] = new int[3];

            matrix2[0][0] = 1;
            matrix2[0][1] = 2;
            matrix2[0][2] = 3;

            matrix2[2][0] = 7;
            matrix2[2][1] = 8;
            matrix2[2][2] = 9;

            matrix2[1][0] = 4;
            matrix2[1][1] = 5;
            matrix2[1][2] = 6;

            MatrixDiagonalSum diagonalSum = new MatrixDiagonalSum();
            diagonalSum.DiagonalSum(matrix2);
            return;

            int[,] matrix1 = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            RotateMatrixBy90 matrixBy90 = new RotateMatrixBy90();
            matrixBy90.Rotate90(matrix1);
            return;

            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            MatrixSnakePattern snakePattern = new MatrixSnakePattern();
            snakePattern.PrintPattern(matrix);
            return;
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
