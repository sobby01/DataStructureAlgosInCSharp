using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Matrix
{
    public class RotateImage
    {
        public void rotate(List<List<int>> a)
        {
            int n = a.Count();
            // transpose matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int tmp = a[j][i];
                    a[j][i] = a[i][j];
                    a[i][j] = tmp;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int tmp = a[i][j];
                    a[i][j] = a[i][n - j - 1];
                    a[i][n - j - 1] = tmp;
                }
            }

        }
    }
}
