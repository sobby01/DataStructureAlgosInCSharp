using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    /*
     * Input: points = [[1,1],[3,4],[-1,0]
     * Output: 7
     */
    public class MinTImeVistingAllPoints
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int totalTime = 0;

            int prevXCordinate = 0;
            int prevYCordinate = 0;

            int currentXCoordinate = 0;
            int currentYCoordinate = 0;

            if (points.Length > 1)
            {
                prevXCordinate = points[0][0];
                prevYCordinate = points[0][1];
                for (int indexer = 1; indexer < points.Length; indexer++)
                {
                    //this will represent current indexers
                    currentXCoordinate = points[indexer][0];
                    currentYCoordinate = points[indexer][1];


                    totalTime += Math.Max(Math.Abs(currentXCoordinate - prevXCordinate),
                        Math.Abs(currentYCoordinate - prevYCordinate));

                    //this will represent old indexers
                    prevXCordinate = points[indexer][0];
                    prevYCordinate = points[indexer][1];
                }
            }
            else
            {
                return 0;
            }
            

            return totalTime;
        }
    }
}
