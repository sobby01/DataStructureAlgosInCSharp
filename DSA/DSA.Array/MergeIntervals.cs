using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayDataStructure
{
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            Comparer<int> comparer = Comparer<int>.Default;
            Array.Sort(intervals, (x, y) => comparer.Compare(x[0], y[0]));
            int rowLength = intervals.GetLength(0);
            List<int[]> arr1 = new List<int[]>();

            for(int i =0; i < rowLength; i++)
            {
                if(arr1.Count == 0 || intervals[i][0] > arr1[arr1.Count-1][1])
                {
                    arr1.Add(new int[] { intervals[i][0], intervals[i][1] });
                }
                else
                {
                    int[] temp = arr1[arr1.Count - 1];
                    arr1[arr1.Count - 1] = new int[] { temp[0], Math.Max(temp[1], intervals[i][1])};
                }
            }

            return arr1.ToArray();
        }
    }
}
