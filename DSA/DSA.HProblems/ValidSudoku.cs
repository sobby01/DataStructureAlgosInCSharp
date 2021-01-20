using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HProblems
{
    public class ValidSudoku
    {
        public bool ProcessSudoku(List<string> A)
        {
            char[][] board = new char[9][];
            int row = 0;
            foreach(string str in A)
            {
                int col = 0;
                board[row] = new char[str.Length];
                for (int i =0; i < str.Length; i++)
                {
                    board[row][col++] = str[i];
                }
                row++;
            }

            return true;
        }

        public bool IsValidSudoku(char[,] board)
        {
            int rowLength = board.GetLength(0);
            int colLength = board.GetLength(1);

            bool isRowValid = true; bool isColumnValid = true; bool isBoxValid = true;
            for (int i = 0; i < rowLength; i++)
            {
                isRowValid = isRowValid && IsValidRow(i, colLength, board);
            }
            if (isRowValid)
            {
                for (int j = 0; j < colLength; j++)
                {
                    isColumnValid = isColumnValid && IsValidColumn(j, rowLength, board);
                }
            }

            if (isRowValid && isColumnValid)
            {

                for (int i = 0; i < rowLength; i = i + 3)
                {
                    for (int j = 0; j < colLength; j = j + 3)
                    {
                        isBoxValid = isBoxValid && IsValidBox(board, i, j);

                    }
                }
            }

            return isRowValid && isColumnValid && isBoxValid;
        }

        private bool IsValidRow(int row, int colLength, char[,] board)
        {
            List<int> list = new List<int>();
            
            for (int i = 0; i < colLength; i++)
            {
                if (list.Contains(board[row,i]))
                {
                    return false;
                }

                if (board[row,i] != '.')
                {
                    list.Add(board[row,i]);
                }
            }

            return true;
        }

        private bool IsValidColumn(int column, int rowLength, char[,] board)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < rowLength; i++)
            {
                if (list.Contains(board[i,column]))
                {
                    return false;
                }

                if (board[i,column] != '.')
                {
                    list.Add(board[i,column]);
                }
            }

            return true;
        }

        private bool IsValidBox(char[,] board,
                               int startRow, int startCol)
        {
            List<int> list = new List<int>();

            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (list.Contains(board[i,j]))
                    {
                        return false;
                    }
                    else if (board[i,j] != '.')
                    {
                        list.Add(board[i,j]);
                    }
                }
            }

            return true;
        }
    }
}
