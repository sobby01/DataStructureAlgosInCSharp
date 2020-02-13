using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class CellWithOddValues
    {
        public int OddCells(int n, int m, int[][] indices)
        {
            int oddCells = 0;
            int[] rows = new int[n];
            int[] columns = new int[m];

            foreach (var index in indices)
            {
                rows[index[0]] += 1;
                columns[index[1]] += 1;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((rows[i] + columns[j]) % 2 == 1)
                    {
                        oddCells++;
                    }
                }
            }

            return oddCells;
        }
    }
}

